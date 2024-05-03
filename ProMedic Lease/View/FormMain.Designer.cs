namespace WinFormsApp1
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSideMenu = new Panel();
            btnLogout = new Button();
            pnlRoleSubmenu = new Panel();
            btnRoleAdd = new Button();
            btnRoleList = new Button();
            btnRole = new Button();
            pnlDoctorSubmenu = new Panel();
            btnDoctorAdd = new Button();
            btnDoctorList = new Button();
            btnDoctor = new Button();
            pnlEmployeeSubmenu = new Panel();
            btnEmployeeAdd = new Button();
            btnEmployeeList = new Button();
            btnEmployee = new Button();
            pnlLogo = new Panel();
            btnSettings = new Button();
            pnlChildForm = new Panel();
            pnlTitle = new Panel();
            labelTitle = new Label();
            pnlSideMenu.SuspendLayout();
            pnlRoleSubmenu.SuspendLayout();
            pnlDoctorSubmenu.SuspendLayout();
            pnlEmployeeSubmenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            pnlTitle.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideMenu
            // 
            pnlSideMenu.AutoScroll = true;
            pnlSideMenu.BackColor = Color.FromArgb(23, 35, 49);
            pnlSideMenu.Controls.Add(btnLogout);
            pnlSideMenu.Controls.Add(pnlRoleSubmenu);
            pnlSideMenu.Controls.Add(btnRole);
            pnlSideMenu.Controls.Add(pnlDoctorSubmenu);
            pnlSideMenu.Controls.Add(btnDoctor);
            pnlSideMenu.Controls.Add(pnlEmployeeSubmenu);
            pnlSideMenu.Controls.Add(btnEmployee);
            pnlSideMenu.Controls.Add(pnlLogo);
            pnlSideMenu.Dock = DockStyle.Left;
            pnlSideMenu.Location = new Point(0, 0);
            pnlSideMenu.Name = "pnlSideMenu";
            pnlSideMenu.Size = new Size(250, 1055);
            pnlSideMenu.TabIndex = 0;
            pnlSideMenu.Paint += pnlSideMenu_Paint;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(23, 35, 49);
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnLogout.ForeColor = Color.WhiteSmoke;
            btnLogout.Location = new Point(0, 1001);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(10, 0, 0, 0);
            btnLogout.Size = new Size(250, 54);
            btnLogout.TabIndex = 7;
            btnLogout.Tag = "Logout";
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnlRoleSubmenu
            // 
            pnlRoleSubmenu.BackColor = Color.FromArgb(31, 47, 66);
            pnlRoleSubmenu.Controls.Add(btnRoleAdd);
            pnlRoleSubmenu.Controls.Add(btnRoleList);
            pnlRoleSubmenu.Dock = DockStyle.Top;
            pnlRoleSubmenu.Location = new Point(0, 424);
            pnlRoleSubmenu.Name = "pnlRoleSubmenu";
            pnlRoleSubmenu.Size = new Size(250, 82);
            pnlRoleSubmenu.TabIndex = 6;
            // 
            // btnRoleAdd
            // 
            btnRoleAdd.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnRoleAdd.Dock = DockStyle.Top;
            btnRoleAdd.FlatAppearance.BorderSize = 0;
            btnRoleAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 189, 241);
            btnRoleAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 189, 241);
            btnRoleAdd.FlatStyle = FlatStyle.Flat;
            btnRoleAdd.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnRoleAdd.ForeColor = Color.WhiteSmoke;
            btnRoleAdd.Location = new Point(0, 43);
            btnRoleAdd.Name = "btnRoleAdd";
            btnRoleAdd.Padding = new Padding(35, 0, 0, 0);
            btnRoleAdd.Size = new Size(250, 40);
            btnRoleAdd.TabIndex = 1;
            btnRoleAdd.Tag = "Add";
            btnRoleAdd.Text = "Add";
            btnRoleAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnRoleAdd.UseVisualStyleBackColor = false;
            btnRoleAdd.Click += btnRoleAdd_Click;
            // 
            // btnRoleList
            // 
            btnRoleList.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnRoleList.Dock = DockStyle.Top;
            btnRoleList.FlatAppearance.BorderSize = 0;
            btnRoleList.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 189, 241);
            btnRoleList.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 189, 241);
            btnRoleList.FlatStyle = FlatStyle.Flat;
            btnRoleList.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnRoleList.ForeColor = Color.WhiteSmoke;
            btnRoleList.Location = new Point(0, 0);
            btnRoleList.Name = "btnRoleList";
            btnRoleList.Padding = new Padding(35, 0, 0, 0);
            btnRoleList.Size = new Size(250, 43);
            btnRoleList.TabIndex = 0;
            btnRoleList.Tag = "List";
            btnRoleList.Text = "List";
            btnRoleList.TextAlign = ContentAlignment.MiddleLeft;
            btnRoleList.UseVisualStyleBackColor = false;
            btnRoleList.Click += btnRoleList_Click;
            // 
            // btnRole
            // 
            btnRole.BackColor = Color.FromArgb(23, 35, 49);
            btnRole.Dock = DockStyle.Top;
            btnRole.FlatAppearance.BorderSize = 0;
            btnRole.FlatStyle = FlatStyle.Flat;
            btnRole.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnRole.ForeColor = Color.WhiteSmoke;
            btnRole.Location = new Point(0, 379);
            btnRole.Name = "btnRole";
            btnRole.Padding = new Padding(10, 0, 0, 0);
            btnRole.Size = new Size(250, 45);
            btnRole.TabIndex = 5;
            btnRole.Tag = "Role";
            btnRole.Text = "Role";
            btnRole.TextAlign = ContentAlignment.MiddleLeft;
            btnRole.UseVisualStyleBackColor = false;
            btnRole.Click += btnRole_Click;
            // 
            // pnlDoctorSubmenu
            // 
            pnlDoctorSubmenu.BackColor = Color.FromArgb(31, 47, 66);
            pnlDoctorSubmenu.Controls.Add(btnDoctorAdd);
            pnlDoctorSubmenu.Controls.Add(btnDoctorList);
            pnlDoctorSubmenu.Dock = DockStyle.Top;
            pnlDoctorSubmenu.Location = new Point(0, 298);
            pnlDoctorSubmenu.Name = "pnlDoctorSubmenu";
            pnlDoctorSubmenu.Size = new Size(250, 81);
            pnlDoctorSubmenu.TabIndex = 4;
            // 
            // btnDoctorAdd
            // 
            btnDoctorAdd.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnDoctorAdd.Dock = DockStyle.Top;
            btnDoctorAdd.FlatAppearance.BorderSize = 0;
            btnDoctorAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 189, 241);
            btnDoctorAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 189, 241);
            btnDoctorAdd.FlatStyle = FlatStyle.Flat;
            btnDoctorAdd.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnDoctorAdd.ForeColor = Color.WhiteSmoke;
            btnDoctorAdd.Location = new Point(0, 40);
            btnDoctorAdd.Name = "btnDoctorAdd";
            btnDoctorAdd.Padding = new Padding(35, 0, 0, 0);
            btnDoctorAdd.Size = new Size(250, 40);
            btnDoctorAdd.TabIndex = 1;
            btnDoctorAdd.Tag = "Add";
            btnDoctorAdd.Text = "Add";
            btnDoctorAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnDoctorAdd.UseVisualStyleBackColor = false;
            btnDoctorAdd.Click += btnDoctorAdd_Click;
            // 
            // btnDoctorList
            // 
            btnDoctorList.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnDoctorList.Dock = DockStyle.Top;
            btnDoctorList.FlatAppearance.BorderSize = 0;
            btnDoctorList.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 189, 241);
            btnDoctorList.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 189, 241);
            btnDoctorList.FlatStyle = FlatStyle.Flat;
            btnDoctorList.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnDoctorList.ForeColor = Color.WhiteSmoke;
            btnDoctorList.Location = new Point(0, 0);
            btnDoctorList.Name = "btnDoctorList";
            btnDoctorList.Padding = new Padding(35, 0, 0, 0);
            btnDoctorList.Size = new Size(250, 40);
            btnDoctorList.TabIndex = 0;
            btnDoctorList.Tag = "List";
            btnDoctorList.Text = "List";
            btnDoctorList.TextAlign = ContentAlignment.MiddleLeft;
            btnDoctorList.UseVisualStyleBackColor = false;
            btnDoctorList.Click += btnDoctorList_Click_1;
            // 
            // btnDoctor
            // 
            btnDoctor.BackColor = Color.FromArgb(23, 35, 49);
            btnDoctor.Dock = DockStyle.Top;
            btnDoctor.FlatAppearance.BorderSize = 0;
            btnDoctor.FlatStyle = FlatStyle.Flat;
            btnDoctor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnDoctor.ForeColor = Color.WhiteSmoke;
            btnDoctor.Location = new Point(0, 253);
            btnDoctor.Name = "btnDoctor";
            btnDoctor.Padding = new Padding(10, 0, 0, 0);
            btnDoctor.Size = new Size(250, 45);
            btnDoctor.TabIndex = 3;
            btnDoctor.Tag = "Doctor’s specializations";
            btnDoctor.Text = "Doctor’s specializations";
            btnDoctor.TextAlign = ContentAlignment.MiddleLeft;
            btnDoctor.UseVisualStyleBackColor = false;
            btnDoctor.Click += btnDoctor_Click;
            // 
            // pnlEmployeeSubmenu
            // 
            pnlEmployeeSubmenu.BackColor = Color.FromArgb(31, 47, 66);
            pnlEmployeeSubmenu.Controls.Add(btnEmployeeAdd);
            pnlEmployeeSubmenu.Controls.Add(btnEmployeeList);
            pnlEmployeeSubmenu.Dock = DockStyle.Top;
            pnlEmployeeSubmenu.Location = new Point(0, 170);
            pnlEmployeeSubmenu.Name = "pnlEmployeeSubmenu";
            pnlEmployeeSubmenu.Size = new Size(250, 83);
            pnlEmployeeSubmenu.TabIndex = 2;
            // 
            // btnEmployeeAdd
            // 
            btnEmployeeAdd.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnEmployeeAdd.Dock = DockStyle.Top;
            btnEmployeeAdd.FlatAppearance.BorderSize = 0;
            btnEmployeeAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 189, 241);
            btnEmployeeAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 189, 241);
            btnEmployeeAdd.FlatStyle = FlatStyle.Flat;
            btnEmployeeAdd.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnEmployeeAdd.ForeColor = Color.WhiteSmoke;
            btnEmployeeAdd.Location = new Point(0, 40);
            btnEmployeeAdd.Name = "btnEmployeeAdd";
            btnEmployeeAdd.Padding = new Padding(35, 0, 0, 0);
            btnEmployeeAdd.Size = new Size(250, 40);
            btnEmployeeAdd.TabIndex = 1;
            btnEmployeeAdd.Tag = "Add";
            btnEmployeeAdd.Text = "Add";
            btnEmployeeAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployeeAdd.UseVisualStyleBackColor = false;
            btnEmployeeAdd.Click += btnEmployeeAdd_Click_1;
            // 
            // btnEmployeeList
            // 
            btnEmployeeList.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnEmployeeList.Dock = DockStyle.Top;
            btnEmployeeList.FlatAppearance.BorderSize = 0;
            btnEmployeeList.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 189, 241);
            btnEmployeeList.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 189, 241);
            btnEmployeeList.FlatStyle = FlatStyle.Flat;
            btnEmployeeList.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnEmployeeList.ForeColor = Color.WhiteSmoke;
            btnEmployeeList.Location = new Point(0, 0);
            btnEmployeeList.Name = "btnEmployeeList";
            btnEmployeeList.Padding = new Padding(35, 0, 0, 0);
            btnEmployeeList.Size = new Size(250, 40);
            btnEmployeeList.TabIndex = 0;
            btnEmployeeList.Tag = "List";
            btnEmployeeList.Text = "List";
            btnEmployeeList.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployeeList.UseVisualStyleBackColor = false;
            btnEmployeeList.Click += btnEmployeeList_Click_1;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.FromArgb(23, 35, 49);
            btnEmployee.Dock = DockStyle.Top;
            btnEmployee.FlatAppearance.BorderSize = 0;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnEmployee.ForeColor = Color.WhiteSmoke;
            btnEmployee.Location = new Point(0, 125);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Padding = new Padding(10, 0, 0, 0);
            btnEmployee.Size = new Size(250, 45);
            btnEmployee.TabIndex = 1;
            btnEmployee.Tag = "Employee";
            btnEmployee.Text = "Employee";
            btnEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click_1;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(23, 35, 49);
            pnlLogo.Controls.Add(btnSettings);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(250, 125);
            pnlLogo.TabIndex = 0;
            // 
            // btnSettings
            // 
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Image = ProMedic_Lease.Properties.Resources.toggle1;
            btnSettings.Location = new Point(184, 3);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(66, 53);
            btnSettings.TabIndex = 1;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnMenu_Click_1;
            // 
            // pnlChildForm
            // 
            pnlChildForm.BackColor = SystemColors.Control;
            pnlChildForm.Location = new Point(250, 125);
            pnlChildForm.Name = "pnlChildForm";
            pnlChildForm.Size = new Size(1419, 680);
            pnlChildForm.TabIndex = 1;
            pnlChildForm.Paint += pnlChildForm_Paint_1;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(23, 35, 49);
            pnlTitle.Controls.Add(labelTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(250, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1419, 125);
            pnlTitle.TabIndex = 0;
            pnlTitle.Paint += pnlTitle_Paint;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold);
            labelTitle.ForeColor = Color.WhiteSmoke;
            labelTitle.Location = new Point(103, 36);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(163, 58);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Home";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1669, 1055);
            Controls.Add(pnlTitle);
            Controls.Add(pnlChildForm);
            Controls.Add(pnlSideMenu);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(950, 600);
            Name = "FormMain";
            Text = "ProMedic Lease";
            Load += FormMain_Load;
            pnlSideMenu.ResumeLayout(false);
            pnlRoleSubmenu.ResumeLayout(false);
            pnlDoctorSubmenu.ResumeLayout(false);
            pnlEmployeeSubmenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideMenu;
        private Button btnLogout;
        private Panel pnlRoleSubmenu;
        private Button btnRoleAdd;
        private Button btnDoctor;
        private Panel pnlEmployeeSubmenu;
        private Button btnEmployeeAdd;
        private Button btnEmployeeList;
        private Button btnEmployee;
        private Panel pnlLogo;
        //Change due to problems with accessing it from different form.
        internal Panel pnlChildForm;
        private Panel pnlTitle;
        private Button btnRoleList;
        private Button btnRole;
        private Panel pnlDoctorSubmenu;
        private Button btnDoctorAdd;
        private Button btnDoctorList;
        private Button btnSettings;
        private Label labelTitle;
    }
}