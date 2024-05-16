using ProMedic_Lease.Models;
using ProMedic_Lease.Patterns.structural;
using ProMedic_Lease.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProMedic_Lease.View
{
    public partial class FormMaintenanceHistory : Form
    {
        private IServiceFacade _serviceFacade;

        public FormMaintenanceHistory(IServiceFacade serviceFacade)
        {
            _serviceFacade = serviceFacade;
            InitializeComponent();
            Refresh();
        }
        private void dgvMaintenanceHistory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMaintenanceHistory.SelectedRows.Count > 0)
            {
                var row = dgvMaintenanceHistory.SelectedRows[0];

                var selectedEquipment = row.Cells["Equipment"].Value as Equipment;

                var equipments = _serviceFacade.EquipmentService.GetAllActive().ToList();
                if (!equipments.Any(e => e.Id == selectedEquipment.Id))
                {
                    equipments.Insert(0, selectedEquipment);
                }

                cmbEquipment.DataSource = equipments;

                chkIsActive.Checked = Convert.ToBoolean(row.Cells["IsActive"].Value);
                dtpDateStart.Value = Convert.ToDateTime(row.Cells["DateStart"].Value);
                txtComment.Text = Convert.ToString(row.Cells["Description"].Value);
                nudCost.Value = Convert.ToDecimal(row.Cells["Cost"].Value);

                var endDate = row.Cells["DateEnd"].Value;
                if (endDate != null)
                {
                    dtpDateEnd.Value = Convert.ToDateTime(endDate);
                    dtpDateEnd.Visible = true;
                }
                else
                {
                    dtpDateEnd.Visible = false;
                }
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FormAddMaintenanceHistory addForm = new FormAddMaintenanceHistory(_serviceFacade))
            {
                DialogResult result = addForm.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    Refresh();
                    MessageBox.Show("Nowa konserwacja została dodanna.", "Dodanie Konserwacji", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.Cancel)
                {
                    Refresh();
                    MessageBox.Show("Dodawanie nowej konserwacji zostało anulowane.", "Anulowano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMaintenanceHistory.SelectedRows.Count > 0)
            {
                var row = dgvMaintenanceHistory.SelectedRows[0];
                long id = Convert.ToInt64(row.Cells["Id"].Value);

                MaintenanceHistory updated = _serviceFacade.MaintenanceHistoryService.GetById(id);
                if (updated == null)
                {
                    MessageBox.Show("Nie znaleziono konserwacji.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Equipment oldEquipment = updated.Equipment;
                updated = PrepareForUpdate(updated);
                Equipment newEquipment = updated.Equipment;

                var validationResult = ValidateData(updated);
                if (!validationResult.IsValid)
                {
                    MessageBox.Show(string.Join("\n", validationResult.Errors), "Błędy walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    if (oldEquipment != newEquipment)
                    {
                        oldEquipment.IsServiced = false;
                        newEquipment.IsServiced = true;
                    }

                    updated.IsActive = updated.DateEnd == null;

                    _serviceFacade.MaintenanceHistoryService.Update(updated);
                    _serviceFacade.EquipmentService.Update(newEquipment);
                    if (oldEquipment != newEquipment)
                        _serviceFacade.EquipmentService.Update(oldEquipment);

                    MessageBox.Show("Pomyślnie zaktualizowano dane konserwacji.", "Aktualizacja zakończona", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd aktualizacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nie zaznaczono żadnej konserwacji.", "Brak selekcji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMaintenanceHistory.SelectedRows.Count > 0)
            {
                var row = dgvMaintenanceHistory.SelectedRows[0];
                long id = Convert.ToInt64(row.Cells["Id"].Value);

                var result = MessageBox.Show("Czy na pewno chcesz usunąć to konserwacje?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _serviceFacade.MaintenanceHistoryService.Delete(id);
                        MessageBox.Show("Konserwacja została usunięta.", "Usunięcie zakończone sukcesem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Wystąpił błąd podczas usuwania wypożyczenia: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnej konserwacji.", "Brak zaznaczenia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;
            var filteredResults = _serviceFacade.MaintenanceHistoryService.Search(searchTerm);
            UpdateGrid(filteredResults);
        }

        private void Refresh()
        {
            var equipments = _serviceFacade.EquipmentService.GetAllActive();
            cmbEquipment.DataSource = equipments;
            cmbEquipment.DisplayMember = "Name";
            cmbEquipment.ValueMember = "Id";

            var employees = _serviceFacade.EmployeeService.GetAllConservator();
            cmbEmployee.DataSource = employees;
            cmbEmployee.DisplayMember = "FullName";
            cmbEmployee.ValueMember = "Id";

            var historyServices = _serviceFacade.MaintenanceHistoryService.GetAll();
            UpdateGrid(historyServices);
        }

        private void UpdateGrid(IEnumerable<MaintenanceHistory> maintenanceHistory)
        {
            dgvMaintenanceHistory.DataSource = maintenanceHistory;
        }

        private MaintenanceHistory PrepareForUpdate(MaintenanceHistory maintenanceHistory)
        {
            maintenanceHistory.Equipment = (Equipment)cmbEquipment.SelectedItem;
            maintenanceHistory.Employee = (Employee)cmbEmployee.SelectedItem;
            maintenanceHistory.DateStart = dtpDateStart.Value;
            maintenanceHistory.DateEnd = dtpDateEnd.Visible ? dtpDateEnd.Value : null;
            maintenanceHistory.Cost = nudCost.Value;
            maintenanceHistory.Description = txtComment.Text;
            maintenanceHistory.IsActive = true;

            return maintenanceHistory;
        }

        private ValidationResult ValidateData(MaintenanceHistory maintenanceHistory)
        {
            List<string> errors = new List<string>();

            if (maintenanceHistory.Equipment == null)
                errors.Add("Sprzęt jest wymagany.");
            if (maintenanceHistory.Employee == null)
                errors.Add("Praocwnik jest wymagany.");
            if (maintenanceHistory.Cost == null)
                errors.Add("Koszt jest wymagany.");
            if (!ValidationHelper.AreDatesValid(maintenanceHistory.DateStart, maintenanceHistory.DateEnd))
                errors.Add("Data zakończenia musi być równa lub późniejsza niż data rozpoczęcia.");

            return new ValidationResult(errors);
        }

        private void chkDisposalDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateEnd.Visible = chkEndDate.Checked;
        }

        private void FormMaintenanceHistory_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void FormMaintenanceHistory_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                Refresh();
            }
        }
    }
}
