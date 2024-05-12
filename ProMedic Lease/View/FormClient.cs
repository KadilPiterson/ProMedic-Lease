using ProMedic_Lease.Models;
using ProMedic_Lease.Patterns.structural;
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
    public partial class FormClient : Form
    {
        private IServiceFacade _serviceFacade;
        public FormClient(IServiceFacade serviceFacade)
        {
            _serviceFacade = serviceFacade;
            InitializeComponent();
            RefreshGrid();
        }

        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                // Pobranie zaznaczonego wiersza
                var row = dgvClients.SelectedRows[0];
                // Aktualizacja TextBoxów
                txtFirstName.Text = Convert.ToString(row.Cells["FirstName"].Value);
                txtLastName.Text = Convert.ToString(row.Cells["LastName"].Value);
                txtEmail.Text = Convert.ToString(row.Cells["Email"].Value);
                txtPesel.Text = Convert.ToString(row.Cells["Pesel"].Value);
                txtPhone.Text = Convert.ToString(row.Cells["Phone"].Value);
                txtStreet.Text = Convert.ToString(row.Cells["Street"].Value);
                nudHouseNumber.Value = Convert.ToDecimal(row.Cells["HouseNumber"].Value);
                nudApartmentNumber.Value = Convert.ToDecimal(row.Cells["ApartmentNumber"].Value);
                txtPostalCode.Text = Convert.ToString(row.Cells["PostalCode"].Value);
                txtCity.Text = Convert.ToString(row.Cells["City"].Value);
                chkIsActive.Checked = Convert.ToBoolean(row.Cells["IsActive"].Value);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FormAddClient addForm = new FormAddClient(_serviceFacade))
            {
                // Show the FormAddEmployee as a modal dialog and capture the result
                DialogResult result = addForm.ShowDialog(this);

                // Handle the dialog result
                if (result == DialogResult.OK)
                {
                    // Refresh the employee grid to reflect added employee
                    RefreshGrid();
                    MessageBox.Show("Nowy klient został dodany.", "Dodanie klienta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.Cancel)
                {
                    // Optionally handle scenarios where Cancel is pressed, if needed
                    MessageBox.Show("Dodawanie nowego klienta zostało anulowane.", "Anulowano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                var row = dgvClients.SelectedRows[0];
                long id = Convert.ToInt64(row.Cells["Id"].Value);

                // Pobranie aktualnych danych pracownika z bazy danych lub pamięci podręcznej
                Client updated = _serviceFacade.ClientService.GetById(id);
                if (updated == null)
                {
                    MessageBox.Show("Nie znaleziono pracownika.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Przygotowanie pracownika do aktualizacji na podstawie danych formularza
                PrepareForUpdate(updated);

                // Walidacja danych pracownika
                var validationResult = ValidateData(updated);
                if (!validationResult.IsValid)
                {
                    MessageBox.Show(string.Join("\n", validationResult.Errors), "Błędy walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Wywołanie serwisu do aktualizacji danych pracownika
                try
                {
                    _serviceFacade.ClientService.Update(updated);
                    MessageBox.Show("Pomyślnie zaktualizowano dane klienta.", "Aktualizacja zakończona", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();  // Odświeżenie DataGridView, aby pokazać zaktualizowane dane
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd aktualizacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nie zaznaczono żadnego klienta.", "Brak selekcji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                var row = dgvClients.SelectedRows[0];
                long id = Convert.ToInt64(row.Cells["Id"].Value);

                var result = MessageBox.Show("Czy na pewno chcesz usunąć tego klienta?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Usuń pracownika za pomocą serwisu
                        _serviceFacade.ClientService.Delete(id);
                        MessageBox.Show("Klient został usunięty.", "Usunięcie zakończone sukcesem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Wystąpił błąd podczas usuwania klienta: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnego klienta.", "Brak zaznaczenia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;
            var filteredResults = _serviceFacade.ClientService.Search(searchTerm);
            UpdateGrid(filteredResults);
        }
        private void RefreshGrid()
        {
            var clients = _serviceFacade.ClientService.GetAll();
            UpdateGrid(clients);
        }

        private void UpdateGrid(IEnumerable<Client> clients)
        {
            dgvClients.DataSource = clients;
        }

        private void PrepareForUpdate(Client client)
        {
            client.FirstName = txtFirstName.Text;
            client.LastName = txtLastName.Text;
            client.Email = txtEmail.Text;
            client.Phone = txtPhone.Text;
            client.Pesel = txtPesel.Text;
            client.Street = txtStreet.Text;
            client.HouseNumber = Convert.ToInt32(nudHouseNumber.Value);
            client.ApartmentNumber = Convert.ToInt32(nudApartmentNumber.Value);
            client.PostalCode = txtPostalCode.Text;
            client.City = txtCity.Text;
            client.IsActive = chkIsActive.Checked;
        }

        private ValidationResult ValidateData(Client client)
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(client.FirstName))
                errors.Add("Imię jest wymagane.");
            if (string.IsNullOrWhiteSpace(client.LastName))
                errors.Add("Nazwisko jest wymagane.");
            if (!ValidationHelper.IsValidEmail(client.Email))
                errors.Add("Podaj prawidłowy email.");
            if (!ValidationHelper.IsValidPhoneNumber(client.Phone))
                errors.Add("Numer telefonu jest nieprawidłowy. Powinien zawierać 9 cyfr.");
            if (!ValidationHelper.IsValidPesel(client.Pesel))
                errors.Add("PESEL jest nieprawidłowy.");
            if (!ValidationHelper.IsValidPostalCode(client.PostalCode))
                errors.Add("Kod pocztowy jest nieprawidłowy. Wymagany format to 00-000.");
            if (client.HouseNumber <= 0)
                errors.Add("Numer domu musi być większy niż 0.");
            if (client.ApartmentNumber < 0)
                errors.Add("Numer lokalu nie może być ujemny.");

            return new ValidationResult(errors);
        }
    }
}
