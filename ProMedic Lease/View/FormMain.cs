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



        private void btnEmployeeList_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEmployee(_serviceFacade));
            lblTitle.Text = "Pracownik";
        }

        private void btnEquipmentList_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEquipment(_serviceFacade));
            lblTitle.Text = "Sprzêt";
        }

        private void btnRentalList_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRental(_serviceFacade));
            lblTitle.Text = "Wypozyczenie";
        }

        private void btnClientList_Click(object sender, EventArgs e)
        {
            openChildForm(new FormClient(_serviceFacade));
            lblTitle.Text = "Klient";
        }

        private void btnMaintenanceHistoryList_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMaintenanceHistory(_serviceFacade));
            lblTitle.Text = "Konserwacja";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlSideMenu.Visible = !pnlSideMenu.Visible;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDepartment(_serviceFacade));
            lblTitle.Text = "Oddzia³";
        }

        private void btnEquipmentType_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEquipmentType(_serviceFacade));
            lblTitle.Text = "Typ sprzêtu";
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            openChildForm(new FormPosition(_serviceFacade));
            lblTitle.Text = "Stanowisko";
        }
    }
}
