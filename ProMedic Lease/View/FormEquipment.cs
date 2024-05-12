using ProMedic_Lease.Models;
using ProMedic_Lease.Patterns.structural;
using ProMedic_Lease.Services;
using ProMedic_Lease.Services.Interfaces;
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

namespace ProMedic_Lease.View
{
    public partial class FormEquipment : Form
    {
        private IServiceFacade _serviceFacade;
        public FormEquipment(IServiceFacade serviceFacade)
        {
            _serviceFacade = serviceFacade;
            InitializeComponent();

            var equipmentypes = _serviceFacade.EquipmentTypeService.GetAll();
            cmbEquipmentType.DataSource = equipmentypes;
            cmbEquipmentType.DisplayMember = "Name";
            cmbEquipmentType.ValueMember = "Id";

            RefreshGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FormAddEquipment addForm = new FormAddEquipment(_serviceFacade))
            {
                // Pokaż FormAddEquipment jako dialog modalny i przechwyć wynik
                DialogResult result = addForm.ShowDialog(this);

                // Obsługa wyniku dialogu
                if (result == DialogResult.OK)
                {
                    // Odświeżenie siatki sprzętu, aby odzwierciedlić dodany sprzęt
                    RefreshGrid();
                    MessageBox.Show("Nowy sprzęt został dodany.", "Dodanie Sprzętu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.Cancel)
                {
                    // Opcjonalnie obsłuż sytuacje, gdy naciśnięto Anuluj
                    MessageBox.Show("Dodawanie nowego sprzętu zostało anulowane.", "Anulowano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMaintenanceHistory.SelectedRows.Count > 0)
            {
                var row = dgvMaintenanceHistory.SelectedRows[0];
                long id = Convert.ToInt64(row.Cells["Id"].Value);

                Equipment updated = _serviceFacade.EquipmentService.GetById(id);
                if (updated == null)
                {
                    MessageBox.Show("Nie znaleziono sprzętu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                updated = PrepareForUpdate(updated);

                var validationResult = ValidateData(updated);
                if (!validationResult.IsValid)
                {
                    MessageBox.Show(string.Join("\n", validationResult.Errors), "Błędy walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    if (updated.DisposalDate != null)
                    {
                        updated.IsActive = false;
                    }
                    _serviceFacade.EquipmentService.Update(updated);
                    MessageBox.Show("Pomyślnie zaktualizowano dane sprzętu.", "Aktualizacja zakończona", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd aktualizacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nie zaznaczono żadnego sprzętu.", "Brak selekcji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMaintenanceHistory.CurrentRow != null)
            {
                var equipment = dgvMaintenanceHistory.CurrentRow.DataBoundItem as Equipment;
                if (equipment != null && MessageBox.Show("Czy na pewno chcesz usunąć ten sprzęt?", "Potwierdzenie Usunięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _serviceFacade.EquipmentService.Delete(equipment.Id);
                    RefreshGrid();
                    MessageBox.Show("Sprzęt został usunięty.", "Usunięcie Sprzętu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Proszę wybrać sprzęt do usunięcia.", "Wymagany Wybór", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;
            var filteredEquipments = _serviceFacade.EquipmentService.Search(searchTerm);
            UpdateGrid(filteredEquipments);
        }

        private void RefreshGrid()
        {
            var equipments = _serviceFacade.EquipmentService.GetAll();
            UpdateGrid(equipments);
        }

        private void UpdateGrid(IEnumerable<Equipment> equipments)
        {
            dgvMaintenanceHistory.DataSource = equipments;
        }

        private Equipment PrepareForUpdate(Equipment equipment)
        {
            equipment.Name = txtName.Text;
            equipment.InventoryNumber = txtInventoryNumber.Text;
            equipment.PurchaseDate = dtpPurchaseDate.Value;
            equipment.InvoiceNumber = txtInvoiceNumber.Text;
            equipment.IdentificationNumber = txtIdentificationNumber.Text;
            equipment.IsServiced = chkIsServiced.Checked;
            equipment.IsInTransit = chkIsInTransit.Checked;
            equipment.IsActive = chkStatus.Checked;
            equipment.EquipmentType = cmbEquipmentType.SelectedItem as EquipmentType;
            equipment.DailyRentalPrice = nudDailyRentalPrice.Value;

            // Obsługa null dla daty zakończenia zatrudnienia
            if (dtpDisposalDate.Visible && dtpDisposalDate.Value != DateTime.MinValue)
            {
                equipment.DisposalDate = dtpDisposalDate.Value;
            }
            else
            {
                equipment.DisposalDate = null;
            }

            return equipment;
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

            if (equipment.IsActive == false)
            {
                errors.Add("Nie można usunąć sprzętu, który jest przydzielony");
            }

            if (equipment.EquipmentType == null || equipment.EquipmentType.Id == 0)
                errors.Add("Typ sprzętu musi być określony.");

            if (equipment.PurchaseDate != null && equipment.DisposalDate != null && equipment.PurchaseDate > equipment.DisposalDate)
                errors.Add("Data zakupu nie może być późniejsza niż data likwidacji.");

            return new ValidationResult(errors);
        }


        private void dgvEquipment_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMaintenanceHistory.SelectedRows.Count > 0)
            {
                var row = dgvMaintenanceHistory.SelectedRows[0];

                txtName.Text = Convert.ToString(row.Cells["Name"].Value);
                txtInventoryNumber.Text = Convert.ToString(row.Cells["InventoryNumber"].Value);
                txtInvoiceNumber.Text = Convert.ToString(row.Cells["InvoiceNumber"].Value);
                txtIdentificationNumber.Text = Convert.ToString(row.Cells["IdentificationNumber"].Value);
                chkIsServiced.Checked = Convert.ToBoolean(row.Cells["IsServiced"].Value);
                chkIsInTransit.Checked = Convert.ToBoolean(row.Cells["IsInTransit"].Value);
                chkStatus.Checked = Convert.ToBoolean(row.Cells["IsActive"].Value);
                dtpPurchaseDate.Value = Convert.ToDateTime(row.Cells["PurchaseDate"].Value);
                var disposalDate = row.Cells["DisposalDate"].Value;
                if (disposalDate != null)
                {
                    dtpDisposalDate.Value = Convert.ToDateTime(disposalDate);
                    dtpDisposalDate.Visible = true;
                }
                else
                {
                    dtpDisposalDate.Visible = false;
                }

                cmbEquipmentType.SelectedItem = row.Cells["EquipmentType"].Value;
            }
        }

        private void chkIsTerminationDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpDisposalDate.Visible = chkDisposalDate.Checked;
        }
    }
}
