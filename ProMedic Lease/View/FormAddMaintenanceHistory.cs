using ProMedic_Lease.Models;
using ProMedic_Lease.Patterns.structural;
using ProMedic_Lease.Utilities;

namespace ProMedic_Lease.View
{
    public partial class FormAddMaintenanceHistory : Form
    {
        private IServiceFacade _serviceRentalFacade;

        public FormAddMaintenanceHistory(IServiceFacade serviceRentalFacade)
        {
            _serviceRentalFacade = serviceRentalFacade;
            InitializeComponent();
            LoadEquipmentTypeComboBox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MaintenanceHistory @new = CreateFromFormData();

            var validationResult = ValidateData(@new);
            if (!validationResult.IsValid)
            {
                MessageBox.Show(string.Join("\n", validationResult.Errors), "Błędy walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Equipment equipment = @new.Equipment;
                equipment.IsServiced = true;

                _serviceRentalFacade.EquipmentService.Update(equipment);
                _serviceRentalFacade.MaintenanceHistoryService.Add(@new);
                LoadEquipmentTypeComboBox();
                MessageBox.Show("Konserwacja została dodana pomyślnie.", "Dodanie Konserwacji", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            var employees = _serviceRentalFacade.EmployeeService.GetAllConservator();
            cmbEmployee.DataSource = employees;
            cmbEmployee.DisplayMember = "FullName";
            cmbEmployee.ValueMember = "Id";
            cmbEmployee.SelectedIndex = -1;
        }

        private MaintenanceHistory CreateFromFormData()
        {
            var equipment = cmbEquipment.SelectedItem as Equipment;
            if (equipment != null)
            {
                equipment.IsServiced = true;
            }

            return new MaintenanceHistory
            {
                Equipment = equipment,
                DateStart = dtpDateStart.Value,
                Employee = cmbEmployee.SelectedItem as Employee,
                Cost = nudCost.Value,
                Description = txtComment.Text,
                IsActive = true,
            };
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

            return new ValidationResult(errors);
        }
    }
}
