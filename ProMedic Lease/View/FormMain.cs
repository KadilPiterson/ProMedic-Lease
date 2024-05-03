using System.Drawing.Text;


namespace WinFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            customizeDesing();
            //CollapseMenu();
            btnSettings.Visible = false;
            //string username = LoginServices.GetUsername();
            //string role = LoginServices.GetRole();
            //btnLog(role);
            //if (string.IsNullOrEmpty(role))
            //{
            //    HideAllButtons();
            //    btnLogout.Visible = true;
            //}
            //else if (role == "1")
            //{
            //    btnAdministratorLogin();
            //    customizeDesing();
            //}
            //else if (role == "2")
            //{
            //    btnMedicalDoctorLogin();
            //    customizeDesing();
            //}
            //else if (role == "3")
            //{
            //    btnReceptionLogin();
            //    customizeDesing();
            //}
            //else
            //{
            //    HideAllButtons();
            //    btnLogout.Visible = true;
            //}
        }

        private void customizeDesing()
        {
            //pnlEmployeeSubmenu.Visible = false;
            //pnlDoctorSubmenu.Visible = false;
            //pnlDoctorPanelSubmenu.Visible = false;
            //pnlRoleSubmenu.Visible = false;
            //pnlUsersSubMenu.Visible = false;
            //pnlEmployeeSubmenu.Visible = false;
            //pnlOfficeSubMenu.Visible = false;
            //pnlCalendarSubMenu.Visible = false;
            //pnlRoleSubmenu.Visible = false;
            //pnlPatientSubmenu.Visible = false;
            //pnlMedicalVisitSubmenu.Visible = false;
        }

        private void btnLog(string role)
        {
            //if (string.IsNullOrEmpty(role))
            //{
            //    btnLogout.Visible = true;
            //    btnLogout.Text = "Login";
            //}
            //else if (role == "1" || role == "2" || role == "3")
            //{
            //    btnLogout.Text = "Logout";
            //}
        }

        private void HideAllButtons()
        {
            foreach (Button menuButton in pnlSideMenu.Controls.OfType<Button>())
            {
                menuButton.Visible = false;
            }

            foreach (Panel subMenu in pnlSideMenu.Controls.OfType<Panel>())
            {
                subMenu.Visible = false;
            }
        }
        private void hideSubMenu()
        {
            if (pnlEmployeeSubmenu.Visible == true)
                pnlEmployeeSubmenu.Visible = false;

            if (pnlDoctorSubmenu.Visible == true)
                pnlDoctorSubmenu.Visible = false;

            if (pnlRoleSubmenu.Visible == true)
                pnlRoleSubmenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }

        private Form? activeForm = null;
        public void openChildForm(Form childFrom)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childFrom);
            pnlChildForm.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();

        }

        private void btnEmployeeList_Click_1(object sender, EventArgs e)
        {
            //openChildForm(new FormEmployeeList(this));
            //labelTitle.Text = "Employee List";
        }

        private void btnEmployee_Click_1(object sender, EventArgs e)
        {
            showSubMenu(pnlEmployeeSubmenu);
            //openChildForm(new FormEmployee(this));
        }

        private void btnEmployeeAdd_Click_1(object sender, EventArgs e)
        {
            //openChildForm(new FormAddEmployee(this));
            //labelTitle.Text = "Employee Add";
        }


        private void btnRole_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlRoleSubmenu);
            //openChildForm(new FormRole(this));
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlDoctorSubmenu);
            //openChildForm(new FormDoctors(this));
        }

        private void btnDoctorAdd_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormSpecializationManage(this));
            //labelTitle.Text = "Doctor’s specializations Add";
        }

        private void btnRoleList_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormRolesList(this));
            //labelTitle.Text = "Role List";
        }

        private void btnRoleAdd_Click(object sender, EventArgs e)
        {
            //openChildForm(new FormRoleManage(this));
            //labelTitle.Text = "Role Add";
        }

        private void btnDoctorList_Click_1(object sender, EventArgs e)
        {
            //openChildForm(new FormSpecializationsList(this));
            //labelTitle.Text = "List of Specializations";
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            //openChildForm(new FormSettings(this));
            //labelTitle.Text = "Settings";
        }


        private void pnlChildForm_Paint_1(object sender, PaintEventArgs e)
        {

        }
        public void changeMainLabelText(string text)
        {
            labelTitle.Text = text;
        }


        private void pnlSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // FormLogin formLogin = new FormLogin();
            this.Hide();
            //formLogin.Show();
        }

        private void btnAdministratorLogin()
        {
            btnSettings.Visible = true;
            btnEmployee.Visible = true;
            btnDoctor.Visible = true;
            btnRole.Visible = true;

        }
        private void btnMedicalDoctorLogin()
        {
            btnEmployee.Visible = false;
            btnDoctor.Visible = false;
            btnRole.Visible = false;

        }
        private void btnReceptionLogin()
        {
            btnEmployee.Visible = false;
            btnDoctor.Visible = false;
            btnRole.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}