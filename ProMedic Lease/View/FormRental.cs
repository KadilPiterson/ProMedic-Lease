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

namespace ProMedic_Lease.View
{
    public partial class FormRental : Form
    {
        private IServiceFacade _serviceFacade;
        public FormRental(IServiceFacade serviceFacade)
        {
            _serviceFacade = serviceFacade;
            InitializeComponent();
        }

        private void FormRental_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void dgvRental_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRental.SelectedRows.Count > 0)
            {
                var row = dgvRental.SelectedRows[0];

                var selectedEquipment = row.Cells["Equipment"].Value as Equipment;

                var equipments = _serviceFacade.EquipmentService.GetAllActive().ToList();
                if (!equipments.Any(e => e.Id == selectedEquipment.Id))
                {
                    equipments.Insert(0, selectedEquipment);
                }

                cmbEquipment.DataSource = equipments;
                cmbEquipment.SelectedItem = selectedEquipment;

                cmbClient.SelectedValue = (row.Cells["Client"].Value as Client).Id;
                cmbEmployee.SelectedValue = (row.Cells["Employee"].Value as Employee).Id;
                txtComment.Text = Convert.ToString(row.Cells["Comments"].Value);
                chkIsActive.Checked = Convert.ToBoolean(row.Cells["IsActive"].Value);
                dtpStartDate.Value = Convert.ToDateTime(row.Cells["StartDate"].Value);
                var endDate = row.Cells["EndDate"].Value;
                if (endDate != null)
                {
                    dtpEndDate.Value = Convert.ToDateTime(endDate);
                    dtpEndDate.Visible = true;
                }
                else
                {
                    dtpEndDate.Visible = false;
                }
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FormAddRental addForm = new FormAddRental(_serviceFacade))
            {
                DialogResult result = addForm.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    Refresh();
                    MessageBox.Show("Nowe wypożyczenie zostało dodane.", "Dodanie Wypożyczenia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.Cancel)
                {
                    Refresh();
                    MessageBox.Show("Dodawanie nowego wypożyczenia zostało anulowane.", "Anulowano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvRental.SelectedRows.Count > 0)
            {
                var row = dgvRental.SelectedRows[0];
                long id = Convert.ToInt64(row.Cells["Id"].Value);

                Rental updated = _serviceFacade.RentalService.GetById(id);
                if (updated == null)
                {
                    MessageBox.Show("Nie znaleziono wypożyczenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        oldEquipment.IsActive = true;
                        newEquipment.IsActive = false;
                    }

                    updated.IsActive = updated.EndDate == null;

                    _serviceFacade.RentalService.Update(updated);
                    _serviceFacade.EquipmentService.Update(newEquipment);
                    if (oldEquipment != newEquipment)
                        _serviceFacade.EquipmentService.Update(oldEquipment);

                    MessageBox.Show("Pomyślnie zaktualizowano dane wypożyczenia.", "Aktualizacja zakończona", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd aktualizacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nie zaznaczono żadnego wypożyczenia.", "Brak selekcji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRental.SelectedRows.Count > 0)
            {
                var row = dgvRental.SelectedRows[0];
                long id = Convert.ToInt64(row.Cells["Id"].Value);

                var result = MessageBox.Show("Czy na pewno chcesz usunąć to wypożyczenie?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _serviceFacade.RentalService.Delete(id);
                        MessageBox.Show("Wypożyczenie zostało usunięte.", "Usunięcie zakończone sukcesem", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Nie wybrano żadnego wypożyczenia.", "Brak zaznaczenia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;
            var filteredResults = _serviceFacade.RentalService.Search(searchTerm);
            UpdateGrid(filteredResults);
        }

        private void Refresh()
        {
            var equipments = _serviceFacade.EquipmentService.GetAllActive();
            cmbEquipment.DataSource = equipments;
            cmbEquipment.DisplayMember = "Name";
            cmbEquipment.ValueMember = "Id";

            var clients = _serviceFacade.ClientService.GetAllActive();
            cmbClient.DataSource = clients;
            cmbClient.DisplayMember = "FullName";
            cmbClient.ValueMember = "Id";

            var employees = _serviceFacade.EmployeeService.GetAllActive();
            cmbEmployee.DataSource = employees;
            cmbEmployee.DisplayMember = "FullName";
            cmbEmployee.ValueMember = "Id";

            var rentals = _serviceFacade.RentalService.GetAll();
            UpdateGrid(rentals);
        }

        private void UpdateGrid(IEnumerable<Rental> rentals)
        {
            dgvRental.DataSource = rentals;
        }

        private Rental PrepareForUpdate(Rental rental)
        {
            rental.Equipment = (Equipment)cmbEquipment.SelectedItem;
            rental.Client = (Client)cmbClient.SelectedItem;
            rental.Employee = (Employee)cmbEmployee.SelectedItem;
            rental.StartDate = dtpStartDate.Value;
            rental.EndDate = dtpEndDate.Visible ? dtpEndDate.Value : null;
            rental.Comments = txtComment.Text;
            rental.IsActive = false;

            return rental;
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
            if (!ValidationHelper.AreDatesValid(rental.StartDate, rental.EndDate))
                errors.Add("Data zakończenia musi być równa lub późniejsza niż data rozpoczęcia.");

            return new ValidationResult(errors);
        }

        private void chkIsEndDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpEndDate.Visible = chkIsEndDate.Checked;
        }
    }
}
