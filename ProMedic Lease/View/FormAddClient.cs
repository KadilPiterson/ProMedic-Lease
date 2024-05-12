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
    public partial class FormAddClient : Form
    {
        private IServiceFacade _serviceFacade;
        public FormAddClient(IServiceFacade serviceFacade)
        {
            InitializeComponent();
            _serviceFacade = serviceFacade;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var validationResult = ValidateData();
            if (!validationResult.IsValid)
            {
                MessageBox.Show(string.Join("\n", validationResult.Errors), "Błędy walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Client @new = CreateFormData();
            try
            {
                _serviceFacade.ClientService.Add(@new);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Client CreateFormData()
        {
            return new Client
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text,
                Pesel = txtPesel.Text,
                Street = txtStreet.Text,
                HouseNumber = Convert.ToInt32(nudHouseNumber.Value),
                ApartmentNumber = Convert.ToInt32(nudApartmentNumber.Value),
                PostalCode = txtPostalCode.Text,
                City = txtCity.Text,
                IsActive = true
            };
        }

        private ValidationResult ValidateData()
        {
            List<string> errors = new List<string>();

            // Check for empty fields
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                errors.Add("Imię jest wymagane.");
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
                errors.Add("Nazwisko jest wymagane.");
            if (!ValidationHelper.IsValidEmail(txtEmail.Text))
                errors.Add("Podaj prawidłowy email.");
            if (!ValidationHelper.IsValidPhoneNumber(txtPhone.Text))
                errors.Add("Numer telefonu jest nieprawidłowy. Powinien zawierać 9 cyfr.");
            if (!ValidationHelper.IsValidPesel(txtPesel.Text))
                errors.Add("PESEL jest nieprawidłowy.");
            if (!ValidationHelper.IsValidPostalCode(txtPostalCode.Text))
                errors.Add("Kod pocztowy jest nieprawidłowy. Wymagany format to 00-000.");
            // Check if numeric values are greater than zero
            if (nudHouseNumber.Value <= 0)
                errors.Add("Numer domu musi być większy niż 0.");
            if (nudApartmentNumber.Value < 0) // Assuming apartment number could be zero for a house
                errors.Add("Numer lokalu nie może być ujemny.");

            return new ValidationResult(errors);
        }
    }
}
