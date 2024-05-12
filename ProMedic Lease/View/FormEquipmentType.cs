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
    public partial class FormEquipmentType : Form
    {
        private IServiceFacade _serviceFacade;
        public FormEquipmentType(IServiceFacade serviceFacade)
        {
            _serviceFacade = serviceFacade;
            InitializeComponent();
            RefreshGrid();
        }

        private void dgvEquipmentType_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEquipmentType.SelectedRows.Count > 0)
            {
                var row = dgvEquipmentType.SelectedRows[0];
                txtName.Text = Convert.ToString(row.Cells["Name"].Value);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FormAddDepartment addForm = new FormAddDepartment(_serviceFacade))
            {
                DialogResult result = addForm.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    RefreshGrid();
                    MessageBox.Show("Nowy typ sprzętu został dodany.", "Dodanie typu sprzętu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Dodawanie nowego typu sprzętu zostało anulowane.", "Anulowano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvEquipmentType.SelectedRows.Count > 0)
            {
                var row = dgvEquipmentType.SelectedRows[0];
                long id = Convert.ToInt64(row.Cells["Id"].Value);

                var updated = _serviceFacade.EquipmentTypeService.GetById(id);
                if (updated == null)
                {
                    MessageBox.Show("Nie znaleziono typu sprzętu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _serviceFacade.EquipmentTypeService.PrepareForUpdate(updated, txtName.Text);

                var validationResult = ValidateData(updated);
                if (!validationResult.IsValid)
                {
                    MessageBox.Show(string.Join("\n", validationResult.Errors), "Błędy walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    _serviceFacade.EquipmentTypeService.Update(updated);
                    MessageBox.Show("Pomyślnie zaktualizowano dane typu sprzętu.", "Aktualizacja zakończona", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd aktualizacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nie zaznaczono żadnego typu sprzętu.", "Brak selekcji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEquipmentType.SelectedRows.Count > 0)
            {
                var row = dgvEquipmentType.SelectedRows[0];
                long id = Convert.ToInt64(row.Cells["Id"].Value);

                var result = MessageBox.Show("Czy na pewno chcesz usunąć ten typ sprzętu?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _serviceFacade.EquipmentTypeService.Delete(id);
                        MessageBox.Show("Typ sprzętu został usunięty.", "Usunięcie zakończone sukcesem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Wystąpił błąd podczas usuwania oddziału: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnego typu sprzętu.", "Brak zaznaczenia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;
            var filteredResults = _serviceFacade.EquipmentTypeService.Search(searchTerm);
            UpdateGrid(filteredResults);
        }
        private void RefreshGrid()
        {
            var equipmentTypes = _serviceFacade.EquipmentTypeService.GetAll();
            UpdateGrid(equipmentTypes);
        }

        private void UpdateGrid(IEnumerable<EquipmentType> equipmentTypes)
        {
            dgvEquipmentType.DataSource = equipmentTypes;
        }

        private ValidationResult ValidateData(EquipmentType equipmentTypes)
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(equipmentTypes.Name))
                errors.Add("Nazwa jest wymagana.");

            return new ValidationResult(errors);
        }
    }
}
