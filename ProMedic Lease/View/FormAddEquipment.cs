using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProMedic_Lease.Models;
using ProMedic_Lease.Patterns.structural;
using ProMedic_Lease.Services.Interfaces;
using ProMedic_Lease.Utilities;

namespace ProMedic_Lease.View
{
    public partial class FormAddEquipment : Form
    {
        private IServiceFacade _serviceFacade;

        public FormAddEquipment(IServiceFacade serviceFacade)
        {
            InitializeComponent();
            _serviceFacade = serviceFacade;
            LoadEquipmentTypeComboBox();
        }

        private void LoadEquipmentTypeComboBox()
        {
            cmbEquipmentType.DataSource = _serviceFacade.EquipmentTypeService.GetAll();
            cmbEquipmentType.DisplayMember = "Name";
            cmbEquipmentType.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Equipment @new = CreateFromFormData();
            var validationResult = ValidateData(@new);
            if (!validationResult.IsValid)
            {
                MessageBox.Show(string.Join("\n", validationResult.Errors), "Błędy walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _serviceFacade.EquipmentService.Add(@new);
                MessageBox.Show("Sprzęt został dodany pomyślnie.", "Dodanie Sprzętu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Equipment CreateFromFormData()
        {
            return new Equipment
            {
                Name = txtName.Text,
                EquipmentType = cmbEquipmentType.SelectedItem as EquipmentType,
                InventoryNumber = $"{numInventoryNumber.Value}/{cmbEquipmentType.SelectedItem.ToString()}/{DateTime.Now.Year}",
                PurchaseDate = dtpPurchaseDate.Value,
                InvoiceNumber = txtInvoiceNumber.Text,
                IdentificationNumber = txtIdentificationNumber.Text,
                IsServiced = false,
                IsInTransit = chkIsInTransit.Checked,
                IsActive = true,
                DailyRentalPrice = nudDailyRentalPrice.Value
            };
        }

        private ValidationResult ValidateData(Equipment equipment)
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(equipment.Name))
                errors.Add("Nazwa sprzętu jest wymagana.");
            if (string.IsNullOrWhiteSpace(equipment.InventoryNumber))
                errors.Add("Numer inwentarzowy jest wymagany.");
            if (string.IsNullOrWhiteSpace(equipment.InvoiceNumber))
                errors.Add("Numer faktury jest wymagany.");
            if (string.IsNullOrWhiteSpace(equipment.IdentificationNumber))
                errors.Add("Numer seryjny jest wymagany.");
            if (equipment.DailyRentalPrice <= 1)
                errors.Add("Cena dzierżawy musi być większa niż 1.");
            if (equipment.EquipmentType == null || equipment.EquipmentType.Id == 0)
                errors.Add("Typ sprzętu musi być określony.");

            return new ValidationResult(errors);
        }

        private void numInventoryNumber_ValueChanged(object sender, EventArgs e)
        {
            txtInventoryNumberView.Text = $"{numInventoryNumber.Value}/{cmbEquipmentType.SelectedItem.ToString().ToUpper()}/{DateTime.Now.Year}";
        }

        private void cmbEquipmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtInventoryNumberView.Text = $"{numInventoryNumber.Value}/{cmbEquipmentType.SelectedItem.ToString().ToUpper()}/{DateTime.Now.Year}";
        }
    }
}
