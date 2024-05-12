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
    public partial class FormPosition : Form
    {
        private IServiceFacade _serviceFacade;
        public FormPosition(IServiceFacade serviceFacade)
        {
            _serviceFacade = serviceFacade;
            InitializeComponent();
            RefreshGrid();
        }

        private void dgvPosition_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPosition.SelectedRows.Count > 0)
            {
                var row = dgvPosition.SelectedRows[0];
                txtName.Text = Convert.ToString(row.Cells["Name"].Value);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FormAddPosition addForm = new FormAddPosition(_serviceFacade))
            {
                DialogResult result = addForm.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    RefreshGrid();
                    MessageBox.Show("Nowe stanowisko zostało dodane.", "Dodanie stanowiska", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Dodawanie nowego stanowiska zostało anulowane.", "Anulowano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvPosition.SelectedRows.Count > 0)
            {
                var row = dgvPosition.SelectedRows[0];
                long id = Convert.ToInt64(row.Cells["Id"].Value);

                var updated = _serviceFacade.PositionService.GetById(id);
                if (updated == null)
                {
                    MessageBox.Show("Nie znaleziono stanowiska.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _serviceFacade.PositionService.PrepareForUpdate(updated, txtName.Text);

                var validationResult = ValidateData(updated);
                if (!validationResult.IsValid)
                {
                    MessageBox.Show(string.Join("\n", validationResult.Errors), "Błędy walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    _serviceFacade.PositionService.Update(updated);
                    MessageBox.Show("Pomyślnie zaktualizowano dane stanowiska.", "Aktualizacja zakończona", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd aktualizacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nie zaznaczono żadnego stanowiska.", "Brak selekcji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPosition.SelectedRows.Count > 0)
            {
                var row = dgvPosition.SelectedRows[0];
                long id = Convert.ToInt64(row.Cells["Id"].Value);

                var result = MessageBox.Show("Czy na pewno chcesz usunąć to stanowisko?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _serviceFacade.PositionService.Delete(id);
                        MessageBox.Show("Stanowisko zostało usunięte.", "Usunięcie zakończone sukcesem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Wystąpił błąd podczas usuwania stanowiska: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnego stanowiska.", "Brak zaznaczenia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;
            var filteredResults = _serviceFacade.PositionService.Search(searchTerm);
            UpdateGrid(filteredResults);
        }
        private void RefreshGrid()
        {
            var positions = _serviceFacade.PositionService.GetAll();
            UpdateGrid(positions);
        }

        private void UpdateGrid(IEnumerable<Position> positions)
        {
            dgvPosition.DataSource = positions;
        }

        private ValidationResult ValidateData(Position position)
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(position.Name))
                errors.Add("Nazwa jest wymagana.");

            return new ValidationResult(errors);
        }
    }
}
