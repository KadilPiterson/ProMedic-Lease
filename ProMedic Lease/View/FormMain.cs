using ProMedic_Lease.Patterns.structural;
using ProMedic_Lease.Services;
using ProMedic_Lease.View;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProMedic_Lease
{
    public partial class FormMain : Form
    {
        private IServiceFacade _serviceFacade;
        private Form? activeForm = null;

        public FormMain(IServiceFacade serviceFacade)
        {
            InitializeComponent();
            _serviceFacade = serviceFacade;
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            // Initially hide all sub-menus
            pnlEmployee.Visible = false;
            pnlEquipment.Visible = false;
            pnlRentalSubmenu.Visible = false;
            pnlClient.Visible = false;
            pnlMaintenanceHistory.Visible = false;
            pnlDictionary.Visible = false;
        }

        private void hideSubMenu()
        {
            foreach (Panel subMenu in pnlSideMenu.Controls.OfType<Panel>())
            {
                if (subMenu != pnlLogo)
                    subMenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // Event handlers for menu buttons
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlEmployee);
        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlEquipment);
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlRentalSubmenu);
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlClient);
        }

        private void btnMaintenanceHistory_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlMaintenanceHistory);
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlDictionary);
        }


        // Event handlers for opening specific forms
        private void btnEmployeeList_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEmployee(_serviceFacade));
        }

        private void btnEquipmentList_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEquipment(_serviceFacade));
        }

        private void btnRentalList_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRental(_serviceFacade));
        }

        private void btnClientList_Click(object sender, EventArgs e)
        {
            openChildForm(new FormClient(_serviceFacade));
        }

        private void btnMaintenanceHistoryList_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMaintenanceHistory(_serviceFacade));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Logout logic
            this.Close(); // For example, close this form
            // Optionally re-open the login form or another form
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlSideMenu.Visible = !pnlSideMenu.Visible;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
