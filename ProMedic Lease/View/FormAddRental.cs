using ProMedic_Lease.Models;
using ProMedic_Lease.Patterns.structural;
using ProMedic_Lease.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProMedic_Lease.View
{
    public partial class FormAddRental : Form
    {
        private IServiceFacade _serviceRentalFacade;

        public FormAddRental(IServiceFacade serviceRentalFacade)
        {
            _serviceRentalFacade = serviceRentalFacade;
            InitializeComponent();
            LoadEquipmentTypeComboBox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Rental @new = CreateFromFormData();

            var validationResult = ValidateData(@new);
            if (!validationResult.IsValid)
            {
                MessageBox.Show(string.Join("\n", validationResult.Errors), "Błędy walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Equipment equipment = @new.Equipment;
                equipment.IsActive = false;

                _serviceRentalFacade.EquipmentService.Update(equipment);
                _serviceRentalFacade.RentalService.Add(@new);
                LoadEquipmentTypeComboBox();
                MessageBox.Show("Wypożyczenie zostało dodane pomyślnie.", "Dodanie Wypożyczenia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEquipmentTypeComboBox()
        {
            var equipments = _serviceRentalFacade.EquipmentService.GetAllActive();
            cmbEquipment.DataSource = equipments;
            cmbEquipment.DisplayMember = "Name";
            cmbEquipment.ValueMember = "Id";
            cmbEquipment.SelectedIndex = -1;

            var clients = _serviceRentalFacade.ClientService.GetAllActive();
            cmbClient.DataSource = clients;
            cmbClient.DisplayMember = "FullName";
            cmbClient.ValueMember = "Id";
            cmbClient.SelectedIndex = -1;

            var employees = _serviceRentalFacade.EmployeeService.GetAllActive();
            cmbEmployee.DataSource = employees;
            cmbEmployee.DisplayMember = "FullName";
            cmbEmployee.ValueMember = "Id";
            cmbEmployee.SelectedIndex = -1;
        }

        private Rental CreateFromFormData()
        {
            var equipment = cmbEquipment.SelectedItem as Equipment;
            if (equipment != null)
            {
                equipment.IsActive = false;
            }

            return new Rental
            {
                Equipment = equipment,
                StartDate = dtpStartDate.Value,
                Client = cmbClient.SelectedItem as Client,
                Employee = cmbEmployee.SelectedItem as Employee,
                Comments = txtComment.Text,
                IsActive = true,
            };
        }

        private ValidationResult ValidateData(Rental rental)
        {
            List<string> errors = new List<string>();

            if (rental.Equipment == null)
                errors.Add("Sprzęt jest wymagany.");
            if (rental.Client == null)
                errors.Add("Klient jest wymagany.");
            if (rental.Employee == null)
                errors.Add("Pracownik jest wymagany.");
            if (rental.StartDate == null)
                errors.Add("Data jest wymagana.");

            return new ValidationResult(errors);
        }
    }
}
