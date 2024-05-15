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
    public partial class FormAddEmployee : Form
    {
        private IServiceFacade _serviceFacade;

        public FormAddEmployee(IServiceFacade serviceFacade)
        {
            InitializeComponent();
            _serviceFacade = serviceFacade;
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            cmbDepartment.DataSource = _serviceFacade.DepartmentService.GetAll();
            cmbDepartment.DisplayMember = "Name";
            cmbDepartment.ValueMember = "Id";

            cmbPosition.DataSource = _serviceFacade.PositionService.GetAll();
            cmbPosition.DisplayMember = "Name";
            cmbPosition.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var validationResult = ValidateData();
            if (!validationResult.IsValid)
            {
                MessageBox.Show(string.Join("\n", validationResult.Errors), "Błędy walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Employee @new = CreateFromFormData();
            try
            {
                _serviceFacade.EmployeeService.Add(@new);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Employee CreateFromFormData()
        {
            return new Employee
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
                EmploymentDate = dtpEmploymentDate.Value,
                Salary = Convert.ToDecimal(nudSalary.Value),
                Department = _serviceFacade.DepartmentService.GetById(Convert.ToInt64(cmbDepartment.SelectedValue)),
                Position = _serviceFacade.PositionService.GetById(Convert.ToInt64(cmbPosition.SelectedValue)),
                IsActive = chkActive.Checked
            };
        }

        private ValidationResult ValidateData()
        {
            List<string> errors = new List<string>();

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
            if (nudSalary.Value <= 0)
                errors.Add("Wynagrodzenie musi być większe niż 0.");
            if (nudHouseNumber.Value <= 0)
                errors.Add("Numer domu musi być większy niż 0.");
            if (nudApartmentNumber.Value < 0)
                errors.Add("Numer lokalu nie może być ujemny.");

            return new ValidationResult(errors);
        }

        private void FormAddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}