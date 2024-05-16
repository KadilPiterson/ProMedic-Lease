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
    public partial class FormAddEquipmentType : Form
    {
        private IServiceFacade _serviceFacade;
        public FormAddEquipmentType(IServiceFacade serviceFacade)
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

            EquipmentType @new = _serviceFacade.EquipmentTypeService.CreateFormData(txtName.Text, txtDescription.Text);
            try
            {
                _serviceFacade.EquipmentTypeService.Add(@new);
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