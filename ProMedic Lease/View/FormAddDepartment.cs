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
    public partial class FormAddDepartment : Form
    {
        private IServiceFacade _serviceFacade;
        public FormAddDepartment(IServiceFacade serviceFacade)
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

            Department @new = _serviceFacade.DepartmentService.CreateFormData(txtName.Text);
            try
            {
                _serviceFacade.DepartmentService.Add(@new);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ValidationResult ValidateData()
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(txtName.Text))
                errors.Add("Nazwa jest wymagana.");

            return new ValidationResult(errors);
        }
    }
}

