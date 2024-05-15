using System;
using System.Windows.Forms;
using ProMedic_Lease.Models;
using ProMedic_Lease.Patterns.structural;
using ProMedic_Lease.Services;
using ProMedic_Lease.Services.Interfaces;
using ProMedic_Lease.Utilities;
using ProMedic_Lease.View;

namespace ProMedic_Lease
{
    public partial class FormEmployee : Form
    {
        private IServiceFacade _serviceFacade;

        public FormEmployee(IServiceFacade serviceFacade)
        {
            _serviceFacade = serviceFacade;
            InitializeComponent();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {

            var departments = _serviceFacade.DepartmentService.GetAll();
            cmbDepartment.DataSource = departments;
            cmbDepartment.DisplayMember = "Name";
            cmbDepartment.ValueMember = "Id";

            var positions = _serviceFacade.PositionService.GetAll();
            cmbPosition.DataSource = positions;
            cmbPosition.DisplayMember = "Name";
            cmbPosition.ValueMember = "Id";


            RefreshGrid();
        }

        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                var row = dgvEmployees.SelectedRows[0];
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
                nudSalary.Value = Convert.ToDecimal(row.Cells["Salary"].Value);
                chkIsActive.Checked = Convert.ToBoolean(row.Cells["IsActive"].Value);
                dtpEmploymentDate.Value = Convert.ToDateTime(row.Cells["EmploymentDate"].Value);

                var terminationDate = row.Cells["TerminationDate"].Value;
                if (terminationDate != null)
                {
                    dtpTerminationDate.Value = Convert.ToDateTime(terminationDate);
                    dtpTerminationDate.Visible = true;
                }
                else
                {
                    dtpTerminationDate.Visible = false;
                }
                cmbDepartment.SelectedItem = row.Cells["DepartmentName"].Value;
                cmbPosition.SelectedItem = row.Cells["PositionName"].Value;

            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FormAddEmployee addForm = new FormAddEmployee(_serviceFacade))
            {
                DialogResult result = addForm.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    RefreshGrid();
                    MessageBox.Show("Nowy pracownik został dodany.", "Dodanie Pracownika", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Dodawanie nowego pracownika zostało anulowane.", "Anulowano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                var row = dgvEmployees.SelectedRows[0];
                long id = Convert.ToInt64(row.Cells["Id"].Value);

                Employee updated = _serviceFacade.EmployeeService.GetById(id);
                if (updated == null)
                {
                    MessageBox.Show("Nie znaleziono pracownika.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                PrepareForUpdate(updated);

                var validationResult = ValidateData(updated);
                if (!validationResult.IsValid)
                {
                    MessageBox.Show(string.Join("\n", validationResult.Errors), "Błędy walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    _serviceFacade.EmployeeService.Update(updated);
                    MessageBox.Show("Pomyślnie zaktualizowano dane pracownika.", "Aktualizacja zakończona", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd aktualizacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nie zaznaczono żadnego pracownika.", "Brak selekcji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                var row = dgvEmployees.SelectedRows[0];
                long id = Convert.ToInt64(row.Cells["Id"].Value);

                var result = MessageBox.Show("Czy na pewno chcesz usunąć tego pracownika?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _serviceFacade.EmployeeService.Delete(id);
                        MessageBox.Show("Pracownik został usunięty.", "Usunięcie zakończone sukcesem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Wystąpił błąd podczas usuwania pracownika: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnego pracownika.", "Brak zaznaczenia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;
            var filteredResults = _serviceFacade.EmployeeService.Search(searchTerm);
            UpdateGrid(filteredResults);
        }

        private void RefreshGrid()
        {
            var employees = _serviceFacade.EmployeeService.GetAll();
            UpdateGrid(employees);
        }

        private void UpdateGrid(IEnumerable<Employee> employees)
        {
            dgvEmployees.DataSource = employees;
        }

        private void chkIsTerminationDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpTerminationDate.Visible = chkIsTerminationDate.Checked;
        }

        private void PrepareForUpdate(Employee employee)
        {
            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            employee.Email = txtEmail.Text;
            employee.Phone = txtPhone.Text;
            employee.Pesel = txtPesel.Text;
            employee.Street = txtStreet.Text;
            employee.HouseNumber = Convert.ToInt32(nudHouseNumber.Value);
            employee.ApartmentNumber = Convert.ToInt32(nudApartmentNumber.Value);
            employee.PostalCode = txtPostalCode.Text;
            employee.City = txtCity.Text;
            employee.Salary = nudSalary.Value;
            employee.EmploymentDate = dtpEmploymentDate.Value;
            employee.Department = (Department)cmbDepartment.SelectedItem;
            employee.Position = (Position)cmbPosition.SelectedItem;
            employee.IsActive = chkIsActive.Checked;

            if (dtpTerminationDate.Visible && dtpTerminationDate.Value != DateTime.MinValue)
            {
                employee.TerminationDate = dtpTerminationDate.Value;
            }
            else
            {
                employee.TerminationDate = null;
            }
        }

        private ValidationResult ValidateData(Employee employee)
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(employee.FirstName))
                errors.Add("Imię jest wymagane.");
            if (string.IsNullOrWhiteSpace(employee.LastName))
                errors.Add("Nazwisko jest wymagane.");
            if (!ValidationHelper.IsValidEmail(employee.Email))
                errors.Add("Podaj prawidłowy email.");
            if (!ValidationHelper.IsValidPhoneNumber(employee.Phone))
                errors.Add("Numer telefonu jest nieprawidłowy. Powinien zawierać 9 cyfr.");
            if (!ValidationHelper.IsValidPesel(employee.Pesel))
                errors.Add("PESEL jest nieprawidłowy.");
            if (!ValidationHelper.IsValidPostalCode(employee.PostalCode))
                errors.Add("Kod pocztowy jest nieprawidłowy. Wymagany format to 00-000.");
            if (employee.Salary <= 0)
                errors.Add("Wynagrodzenie musi być większe niż 0.");
            if (employee.HouseNumber <= 0)
                errors.Add("Numer domu musi być większy niż 0.");
            if (employee.ApartmentNumber < 0)
                errors.Add("Numer lokalu nie może być ujemny.");

            return new ValidationResult(errors);
        }
    }
}
