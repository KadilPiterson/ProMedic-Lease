namespace ProMedic_Lease
{
    partial class FormEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvEmployees = new Krypton.Toolkit.KryptonDataGridView();
            id = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Pesel = new DataGridViewTextBoxColumn();
            Street = new DataGridViewTextBoxColumn();
            HouseNumber = new DataGridViewTextBoxColumn();
            ApartmentNumber = new DataGridViewTextBoxColumn();
            PostalCode = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewCheckBoxColumn();
            EmploymentDate = new DataGridViewTextBoxColumn();
            TerminationDate = new DataGridViewTextBoxColumn();
            Salary = new DataGridViewTextBoxColumn();
            DepartmentName = new DataGridViewTextBoxColumn();
            PositionName = new DataGridViewTextBoxColumn();
            txtSearch = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            btnSearch = new Krypton.Toolkit.KryptonButton();
            btnAdd = new Krypton.Toolkit.KryptonButton();
            btnDelete = new Krypton.Toolkit.KryptonButton();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            txtFirstName = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            txtLastName = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            txtEmail = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            txtPhone = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            txtCity = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            txtPostalCode = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            txtStreet = new Krypton.Toolkit.KryptonTextBox();
            nudApartmentNumber = new Krypton.Toolkit.KryptonNumericUpDown();
            nudHouseNumber = new Krypton.Toolkit.KryptonNumericUpDown();
            dtpEmploymentDate = new Krypton.Toolkit.KryptonDateTimePicker();
            dtpTerminationDate = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel12 = new Krypton.Toolkit.KryptonLabel();
            cmbDepartment = new Krypton.Toolkit.KryptonComboBox();
            cmbPosition = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel13 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel14 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel15 = new Krypton.Toolkit.KryptonLabel();
            nudSalary = new Krypton.Toolkit.KryptonNumericUpDown();
            chkIsActive = new Krypton.Toolkit.KryptonCheckBox();
            btnUpdate = new Krypton.Toolkit.KryptonButton();
            kryptonLabel16 = new Krypton.Toolkit.KryptonLabel();
            txtPesel = new Krypton.Toolkit.KryptonTextBox();
            chkIsTerminationDate = new Krypton.Toolkit.KryptonCheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbDepartment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbPosition).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToOrderColumns = true;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEmployees.BorderStyle = BorderStyle.None;
            dgvEmployees.ColumnHeadersHeight = 36;
            dgvEmployees.Columns.AddRange(new DataGridViewColumn[] { id, FirstName, LastName, Pesel, Street, HouseNumber, ApartmentNumber, PostalCode, City, Email, Phone, IsActive, EmploymentDate, TerminationDate, Salary, DepartmentName, PositionName });
            dgvEmployees.Location = new Point(27, 59);
            dgvEmployees.Margin = new Padding(3, 2, 3, 2);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.Size = new Size(1193, 352);
            dgvEmployees.StateCommon.Background.Color1 = Color.FromArgb(41, 57, 76);
            dgvEmployees.StateCommon.Background.Color2 = Color.FromArgb(41, 57, 76);
            dgvEmployees.StateCommon.Background.ColorAngle = 45F;
            dgvEmployees.StateCommon.Background.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            dgvEmployees.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvEmployees.StateCommon.DataCell.Back.Color1 = Color.FromArgb(41, 57, 76);
            dgvEmployees.StateCommon.DataCell.Back.Color2 = Color.FromArgb(41, 57, 76);
            dgvEmployees.StateCommon.DataCell.Border.Color1 = Color.FromArgb(0, 189, 241);
            dgvEmployees.StateCommon.DataCell.Border.Color2 = Color.FromArgb(0, 189, 241);
            dgvEmployees.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dgvEmployees.StateCommon.DataCell.Content.Color1 = Color.White;
            dgvEmployees.StateCommon.DataCell.Content.Color2 = Color.White;
            dgvEmployees.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(23, 35, 49);
            dgvEmployees.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(23, 35, 49);
            dgvEmployees.StateCommon.HeaderColumn.Border.Color1 = Color.FromArgb(0, 189, 241);
            dgvEmployees.StateCommon.HeaderColumn.Border.Color2 = Color.FromArgb(0, 189, 241);
            dgvEmployees.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dgvEmployees.StateCommon.HeaderColumn.Content.Color1 = Color.White;
            dgvEmployees.StateCommon.HeaderColumn.Content.Color2 = Color.White;
            dgvEmployees.StateCommon.HeaderColumn.Content.ColorAngle = 45F;
            dgvEmployees.StateCommon.HeaderColumn.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dgvEmployees.StateCommon.HeaderRow.Back.Color1 = Color.FromArgb(41, 57, 76);
            dgvEmployees.StateCommon.HeaderRow.Back.Color2 = Color.FromArgb(41, 57, 76);
            dgvEmployees.StateCommon.HeaderRow.Border.Color1 = Color.FromArgb(0, 189, 241);
            dgvEmployees.StateCommon.HeaderRow.Border.Color2 = Color.FromArgb(0, 189, 241);
            dgvEmployees.StateCommon.HeaderRow.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dgvEmployees.StateCommon.HeaderRow.Content.Color1 = Color.White;
            dgvEmployees.StateCommon.HeaderRow.Content.Color2 = Color.White;
            dgvEmployees.TabIndex = 0;
            dgvEmployees.SelectionChanged += dgvEmployees_SelectionChanged;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 52;
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "First Name";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            FirstName.Width = 115;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "Last Name";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            LastName.Width = 114;
            // 
            // Pesel
            // 
            Pesel.DataPropertyName = "Pesel";
            Pesel.HeaderText = "PESEL";
            Pesel.MinimumWidth = 6;
            Pesel.Name = "Pesel";
            Pesel.ReadOnly = true;
            Pesel.Width = 86;
            // 
            // Street
            // 
            Street.DataPropertyName = "Street";
            Street.HeaderText = "Street";
            Street.MinimumWidth = 6;
            Street.Name = "Street";
            Street.ReadOnly = true;
            Street.Width = 81;
            // 
            // HouseNumber
            // 
            HouseNumber.DataPropertyName = "HouseNumber";
            HouseNumber.HeaderText = "House Number";
            HouseNumber.MinimumWidth = 6;
            HouseNumber.Name = "HouseNumber";
            HouseNumber.ReadOnly = true;
            HouseNumber.Width = 144;
            // 
            // ApartmentNumber
            // 
            ApartmentNumber.DataPropertyName = "ApartmentNumber";
            ApartmentNumber.HeaderText = "Apartment Number";
            ApartmentNumber.MinimumWidth = 6;
            ApartmentNumber.Name = "ApartmentNumber";
            ApartmentNumber.ReadOnly = true;
            ApartmentNumber.Width = 172;
            // 
            // PostalCode
            // 
            PostalCode.DataPropertyName = "PostalCode";
            PostalCode.HeaderText = "Postal Code";
            PostalCode.MinimumWidth = 6;
            PostalCode.Name = "PostalCode";
            PostalCode.ReadOnly = true;
            PostalCode.Width = 124;
            // 
            // City
            // 
            City.DataPropertyName = "City";
            City.HeaderText = "City";
            City.MinimumWidth = 6;
            City.Name = "City";
            City.ReadOnly = true;
            City.Width = 64;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 76;
            // 
            // Phone
            // 
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            Phone.Width = 83;
            // 
            // IsActive
            // 
            IsActive.DataPropertyName = "IsActive";
            IsActive.HeaderText = "Is Active";
            IsActive.MinimumWidth = 6;
            IsActive.Name = "IsActive";
            IsActive.ReadOnly = true;
            IsActive.Width = 79;
            // 
            // EmploymentDate
            // 
            EmploymentDate.DataPropertyName = "EmploymentDate";
            EmploymentDate.HeaderText = "Employment Date";
            EmploymentDate.MinimumWidth = 6;
            EmploymentDate.Name = "EmploymentDate";
            EmploymentDate.ReadOnly = true;
            EmploymentDate.Width = 163;
            // 
            // TerminationDate
            // 
            TerminationDate.DataPropertyName = "TerminationDate";
            TerminationDate.HeaderText = "Termination Date";
            TerminationDate.MinimumWidth = 6;
            TerminationDate.Name = "TerminationDate";
            TerminationDate.ReadOnly = true;
            TerminationDate.Width = 162;
            // 
            // Salary
            // 
            Salary.DataPropertyName = "Salary";
            Salary.HeaderText = "Salary";
            Salary.MinimumWidth = 6;
            Salary.Name = "Salary";
            Salary.ReadOnly = true;
            Salary.Width = 83;
            // 
            // DepartmentName
            // 
            DepartmentName.DataPropertyName = "Department";
            DepartmentName.HeaderText = "Department";
            DepartmentName.MinimumWidth = 6;
            DepartmentName.Name = "DepartmentName";
            DepartmentName.ReadOnly = true;
            DepartmentName.Width = 121;
            // 
            // PositionName
            // 
            PositionName.DataPropertyName = "Position";
            PositionName.HeaderText = "Position";
            PositionName.MinimumWidth = 6;
            PositionName.Name = "PositionName";
            PositionName.ReadOnly = true;
            PositionName.Width = 95;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(27, 32);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(153, 26);
            txtSearch.StateCommon.Back.Color1 = Color.White;
            txtSearch.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSearch.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtSearch.StateCommon.Border.Rounding = 12.5F;
            txtSearch.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtSearch.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtSearch.TabIndex = 1;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(27, 12);
            kryptonLabel1.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(69, 18);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel1.TabIndex = 2;
            kryptonLabel1.Values.Text = "Wyszukaj:";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(186, 32);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.OverrideDefault.Back.Color1 = Color.FromArgb(23, 35, 49);
            btnSearch.OverrideDefault.Back.Color2 = Color.FromArgb(23, 35, 49);
            btnSearch.OverrideDefault.Back.ColorAngle = 45F;
            btnSearch.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSearch.OverrideDefault.Border.Color1 = Color.FromArgb(23, 35, 49);
            btnSearch.OverrideDefault.Border.Color2 = Color.FromArgb(23, 35, 49);
            btnSearch.OverrideDefault.Border.ColorAngle = 45F;
            btnSearch.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSearch.OverrideDefault.Border.Rounding = 12.5F;
            btnSearch.OverrideDefault.Border.Width = 1;
            btnSearch.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnSearch.Size = new Size(158, 23);
            btnSearch.StateCommon.Back.Color1 = Color.FromArgb(23, 35, 49);
            btnSearch.StateCommon.Back.Color2 = Color.FromArgb(23, 35, 49);
            btnSearch.StateCommon.Back.ColorAngle = 45F;
            btnSearch.StateCommon.Border.Color1 = Color.FromArgb(23, 35, 49);
            btnSearch.StateCommon.Border.Color2 = Color.FromArgb(23, 35, 49);
            btnSearch.StateCommon.Border.ColorAngle = 45F;
            btnSearch.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSearch.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSearch.StateCommon.Border.Rounding = 12.5F;
            btnSearch.StateCommon.Border.Width = 1;
            btnSearch.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSearch.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSearch.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnSearch.StatePressed.Back.Color1 = Color.FromArgb(0, 189, 241);
            btnSearch.StatePressed.Back.Color2 = Color.FromArgb(0, 189, 241);
            btnSearch.StatePressed.Back.ColorAngle = 130F;
            btnSearch.StatePressed.Border.Color1 = Color.FromArgb(0, 189, 241);
            btnSearch.StatePressed.Border.Color2 = Color.FromArgb(0, 189, 241);
            btnSearch.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSearch.StatePressed.Border.Rounding = 12.5F;
            btnSearch.StatePressed.Border.Width = 1;
            btnSearch.StateTracking.Back.Color1 = Color.FromArgb(0, 189, 241);
            btnSearch.StateTracking.Back.ColorAngle = 45F;
            btnSearch.StateTracking.Border.Color1 = Color.FromArgb(0, 189, 241);
            btnSearch.StateTracking.Border.Color2 = Color.FromArgb(0, 189, 241);
            btnSearch.StateTracking.Border.ColorAngle = 45F;
            btnSearch.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSearch.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSearch.StateTracking.Border.Rounding = 12.5F;
            btnSearch.StateTracking.Border.Width = 1;
            btnSearch.TabIndex = 4;
            btnSearch.Values.Text = "Wyszukaj";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(898, 32);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.OverrideDefault.Back.Color1 = Color.FromArgb(23, 35, 49);
            btnAdd.OverrideDefault.Back.Color2 = Color.FromArgb(23, 35, 49);
            btnAdd.OverrideDefault.Back.ColorAngle = 45F;
            btnAdd.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAdd.OverrideDefault.Border.Color1 = Color.FromArgb(23, 35, 49);
            btnAdd.OverrideDefault.Border.Color2 = Color.FromArgb(23, 35, 49);
            btnAdd.OverrideDefault.Border.ColorAngle = 45F;
            btnAdd.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAdd.OverrideDefault.Border.Rounding = 12.5F;
            btnAdd.OverrideDefault.Border.Width = 1;
            btnAdd.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnAdd.Size = new Size(158, 23);
            btnAdd.StateCommon.Back.Color1 = Color.FromArgb(23, 35, 49);
            btnAdd.StateCommon.Back.Color2 = Color.FromArgb(23, 35, 49);
            btnAdd.StateCommon.Back.ColorAngle = 45F;
            btnAdd.StateCommon.Border.Color1 = Color.FromArgb(23, 35, 49);
            btnAdd.StateCommon.Border.Color2 = Color.FromArgb(23, 35, 49);
            btnAdd.StateCommon.Border.ColorAngle = 45F;
            btnAdd.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAdd.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAdd.StateCommon.Border.Rounding = 12.5F;
            btnAdd.StateCommon.Border.Width = 1;
            btnAdd.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAdd.StateCommon.Content.ShortText.Color2 = Color.White;
            btnAdd.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnAdd.StatePressed.Back.Color1 = Color.FromArgb(0, 189, 241);
            btnAdd.StatePressed.Back.Color2 = Color.FromArgb(0, 189, 241);
            btnAdd.StatePressed.Back.ColorAngle = 130F;
            btnAdd.StatePressed.Border.Color1 = Color.FromArgb(0, 189, 241);
            btnAdd.StatePressed.Border.Color2 = Color.FromArgb(0, 189, 241);
            btnAdd.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAdd.StatePressed.Border.Rounding = 12.5F;
            btnAdd.StatePressed.Border.Width = 1;
            btnAdd.StateTracking.Back.Color1 = Color.FromArgb(0, 189, 241);
            btnAdd.StateTracking.Back.ColorAngle = 45F;
            btnAdd.StateTracking.Border.Color1 = Color.FromArgb(0, 189, 241);
            btnAdd.StateTracking.Border.Color2 = Color.FromArgb(0, 189, 241);
            btnAdd.StateTracking.Border.ColorAngle = 45F;
            btnAdd.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAdd.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAdd.StateTracking.Border.Rounding = 12.5F;
            btnAdd.StateTracking.Border.Width = 1;
            btnAdd.TabIndex = 5;
            btnAdd.Values.Text = "Dodaj";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1060, 32);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.OverrideDefault.Back.Color1 = Color.FromArgb(23, 35, 49);
            btnDelete.OverrideDefault.Back.Color2 = Color.FromArgb(23, 35, 49);
            btnDelete.OverrideDefault.Back.ColorAngle = 45F;
            btnDelete.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnDelete.OverrideDefault.Border.Color1 = Color.FromArgb(23, 35, 49);
            btnDelete.OverrideDefault.Border.Color2 = Color.FromArgb(23, 35, 49);
            btnDelete.OverrideDefault.Border.ColorAngle = 45F;
            btnDelete.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnDelete.OverrideDefault.Border.Rounding = 12.5F;
            btnDelete.OverrideDefault.Border.Width = 1;
            btnDelete.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnDelete.Size = new Size(158, 23);
            btnDelete.StateCommon.Back.Color1 = Color.FromArgb(23, 35, 49);
            btnDelete.StateCommon.Back.Color2 = Color.FromArgb(23, 35, 49);
            btnDelete.StateCommon.Back.ColorAngle = 45F;
            btnDelete.StateCommon.Border.Color1 = Color.FromArgb(23, 35, 49);
            btnDelete.StateCommon.Border.Color2 = Color.FromArgb(23, 35, 49);
            btnDelete.StateCommon.Border.ColorAngle = 45F;
            btnDelete.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnDelete.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnDelete.StateCommon.Border.Rounding = 12.5F;
            btnDelete.StateCommon.Border.Width = 1;
            btnDelete.StateCommon.Content.ShortText.Color1 = Color.White;
            btnDelete.StateCommon.Content.ShortText.Color2 = Color.White;
            btnDelete.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnDelete.StatePressed.Back.Color1 = Color.FromArgb(0, 189, 241);
            btnDelete.StatePressed.Back.Color2 = Color.FromArgb(0, 189, 241);
            btnDelete.StatePressed.Back.ColorAngle = 130F;
            btnDelete.StatePressed.Border.Color1 = Color.FromArgb(0, 189, 241);
            btnDelete.StatePressed.Border.Color2 = Color.FromArgb(0, 189, 241);
            btnDelete.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnDelete.StatePressed.Border.Rounding = 12.5F;
            btnDelete.StatePressed.Border.Width = 1;
            btnDelete.StateTracking.Back.Color1 = Color.FromArgb(0, 189, 241);
            btnDelete.StateTracking.Back.ColorAngle = 45F;
            btnDelete.StateTracking.Border.Color1 = Color.FromArgb(0, 189, 241);
            btnDelete.StateTracking.Border.Color2 = Color.FromArgb(0, 189, 241);
            btnDelete.StateTracking.Border.ColorAngle = 45F;
            btnDelete.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnDelete.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnDelete.StateTracking.Border.Rounding = 12.5F;
            btnDelete.StateTracking.Border.Width = 1;
            btnDelete.TabIndex = 6;
            btnDelete.Values.Text = "Usuń";
            btnDelete.Click += btnDelete_Click;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(27, 431);
            kryptonLabel2.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(39, 18);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel2.TabIndex = 8;
            kryptonLabel2.Values.Text = "Imie:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(27, 452);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(153, 26);
            txtFirstName.StateCommon.Back.Color1 = Color.White;
            txtFirstName.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtFirstName.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtFirstName.StateCommon.Border.Rounding = 12.5F;
            txtFirstName.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtFirstName.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtFirstName.TabIndex = 7;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(186, 431);
            kryptonLabel3.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(69, 18);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel3.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel3.TabIndex = 10;
            kryptonLabel3.Values.Text = "Nazwisko:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(186, 452);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(153, 26);
            txtLastName.StateCommon.Back.Color1 = Color.White;
            txtLastName.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtLastName.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtLastName.StateCommon.Border.Rounding = 12.5F;
            txtLastName.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtLastName.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtLastName.TabIndex = 9;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(344, 431);
            kryptonLabel4.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(46, 18);
            kryptonLabel4.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel4.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel4.TabIndex = 12;
            kryptonLabel4.Values.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(344, 452);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(153, 26);
            txtEmail.StateCommon.Back.Color1 = Color.White;
            txtEmail.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtEmail.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtEmail.StateCommon.Border.Rounding = 12.5F;
            txtEmail.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtEmail.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtEmail.TabIndex = 11;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(502, 431);
            kryptonLabel5.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(57, 18);
            kryptonLabel5.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel5.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel5.TabIndex = 14;
            kryptonLabel5.Values.Text = "Telefon:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(502, 452);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(153, 26);
            txtPhone.StateCommon.Back.Color1 = Color.White;
            txtPhone.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPhone.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtPhone.StateCommon.Border.Rounding = 12.5F;
            txtPhone.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtPhone.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtPhone.TabIndex = 13;
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(186, 495);
            kryptonLabel6.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(59, 18);
            kryptonLabel6.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel6.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel6.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel6.TabIndex = 16;
            kryptonLabel6.Values.Text = "Miastko:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(186, 515);
            txtCity.Margin = new Padding(3, 2, 3, 2);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(153, 26);
            txtCity.StateCommon.Back.Color1 = Color.White;
            txtCity.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtCity.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtCity.StateCommon.Border.Rounding = 12.5F;
            txtCity.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtCity.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtCity.TabIndex = 15;
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(344, 495);
            kryptonLabel7.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(94, 18);
            kryptonLabel7.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel7.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel7.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel7.TabIndex = 18;
            kryptonLabel7.Values.Text = "Kod pocztowy:";
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(344, 515);
            txtPostalCode.Margin = new Padding(3, 2, 3, 2);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(153, 26);
            txtPostalCode.StateCommon.Back.Color1 = Color.White;
            txtPostalCode.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPostalCode.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtPostalCode.StateCommon.Border.Rounding = 12.5F;
            txtPostalCode.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtPostalCode.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtPostalCode.TabIndex = 17;
            // 
            // kryptonLabel8
            // 
            kryptonLabel8.Location = new Point(502, 495);
            kryptonLabel8.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel8.Name = "kryptonLabel8";
            kryptonLabel8.Size = new Size(43, 18);
            kryptonLabel8.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel8.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel8.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel8.TabIndex = 20;
            kryptonLabel8.Values.Text = "Ulica:";
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(502, 515);
            txtStreet.Margin = new Padding(3, 2, 3, 2);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(153, 26);
            txtStreet.StateCommon.Back.Color1 = Color.White;
            txtStreet.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtStreet.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtStreet.StateCommon.Border.Rounding = 12.5F;
            txtStreet.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtStreet.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtStreet.TabIndex = 19;
            // 
            // nudApartmentNumber
            // 
            nudApartmentNumber.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            nudApartmentNumber.Location = new Point(661, 515);
            nudApartmentNumber.Margin = new Padding(3, 2, 3, 2);
            nudApartmentNumber.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudApartmentNumber.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            nudApartmentNumber.Name = "nudApartmentNumber";
            nudApartmentNumber.Size = new Size(70, 30);
            nudApartmentNumber.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            nudApartmentNumber.StateCommon.Border.Rounding = 12.5F;
            nudApartmentNumber.StateCommon.Border.Width = 1;
            nudApartmentNumber.TabIndex = 21;
            nudApartmentNumber.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // nudHouseNumber
            // 
            nudHouseNumber.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            nudHouseNumber.Location = new Point(748, 515);
            nudHouseNumber.Margin = new Padding(3, 2, 3, 2);
            nudHouseNumber.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudHouseNumber.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            nudHouseNumber.Name = "nudHouseNumber";
            nudHouseNumber.Size = new Size(66, 30);
            nudHouseNumber.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            nudHouseNumber.StateCommon.Border.Rounding = 12.5F;
            nudHouseNumber.StateCommon.Border.Width = 1;
            nudHouseNumber.TabIndex = 22;
            nudHouseNumber.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // dtpEmploymentDate
            // 
            dtpEmploymentDate.Location = new Point(819, 452);
            dtpEmploymentDate.Margin = new Padding(3, 2, 3, 2);
            dtpEmploymentDate.Name = "dtpEmploymentDate";
            dtpEmploymentDate.Size = new Size(139, 26);
            dtpEmploymentDate.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpEmploymentDate.StateCommon.Border.Rounding = 12.5F;
            dtpEmploymentDate.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dtpEmploymentDate.TabIndex = 23;
            dtpEmploymentDate.ValueNullable = new DateTime(2024, 1, 1, 19, 52, 0, 0);
            // 
            // dtpTerminationDate
            // 
            dtpTerminationDate.Location = new Point(819, 519);
            dtpTerminationDate.Margin = new Padding(3, 2, 3, 2);
            dtpTerminationDate.Name = "dtpTerminationDate";
            dtpTerminationDate.Size = new Size(139, 26);
            dtpTerminationDate.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpTerminationDate.StateCommon.Border.Rounding = 12.5F;
            dtpTerminationDate.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dtpTerminationDate.TabIndex = 24;
            dtpTerminationDate.ValueNullable = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // kryptonLabel9
            // 
            kryptonLabel9.Location = new Point(661, 495);
            kryptonLabel9.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel9.Name = "kryptonLabel9";
            kryptonLabel9.Size = new Size(63, 18);
            kryptonLabel9.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel9.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel9.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel9.TabIndex = 25;
            kryptonLabel9.Values.Text = "Nr domu:";
            // 
            // kryptonLabel10
            // 
            kryptonLabel10.Location = new Point(748, 495);
            kryptonLabel10.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel10.Name = "kryptonLabel10";
            kryptonLabel10.Size = new Size(65, 18);
            kryptonLabel10.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel10.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel10.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel10.TabIndex = 26;
            kryptonLabel10.Values.Text = "Nr lokalu:";
            // 
            // kryptonLabel11
            // 
            kryptonLabel11.Location = new Point(819, 432);
            kryptonLabel11.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel11.Name = "kryptonLabel11";
            kryptonLabel11.Size = new Size(115, 18);
            kryptonLabel11.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel11.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel11.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel11.TabIndex = 27;
            kryptonLabel11.Values.Text = "Data zatrudnienia:";
            // 
            // kryptonLabel12
            // 
            kryptonLabel12.Location = new Point(819, 499);
            kryptonLabel12.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel12.Name = "kryptonLabel12";
            kryptonLabel12.Size = new Size(92, 18);
            kryptonLabel12.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel12.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel12.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel12.TabIndex = 28;
            kryptonLabel12.Values.Text = "Data odejścia:";
            // 
            // cmbDepartment
            // 
            cmbDepartment.DropDownWidth = 151;
            cmbDepartment.IntegralHeight = false;
            cmbDepartment.Location = new Point(963, 452);
            cmbDepartment.Margin = new Padding(3, 2, 3, 2);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(139, 29);
            cmbDepartment.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbDepartment.StateCommon.ComboBox.Border.Rounding = 12.5F;
            cmbDepartment.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbDepartment.StateCommon.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cmbDepartment.TabIndex = 29;
            // 
            // cmbPosition
            // 
            cmbPosition.DropDownWidth = 151;
            cmbPosition.IntegralHeight = false;
            cmbPosition.Location = new Point(963, 519);
            cmbPosition.Margin = new Padding(3, 2, 3, 2);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(139, 29);
            cmbPosition.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbPosition.StateCommon.ComboBox.Border.Rounding = 12.5F;
            cmbPosition.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbPosition.TabIndex = 30;
            // 
            // kryptonLabel13
            // 
            kryptonLabel13.Location = new Point(963, 432);
            kryptonLabel13.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel13.Name = "kryptonLabel13";
            kryptonLabel13.Size = new Size(58, 18);
            kryptonLabel13.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel13.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel13.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel13.TabIndex = 31;
            kryptonLabel13.Values.Text = "Oddział:";
            // 
            // kryptonLabel14
            // 
            kryptonLabel14.Location = new Point(963, 499);
            kryptonLabel14.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel14.Name = "kryptonLabel14";
            kryptonLabel14.Size = new Size(80, 18);
            kryptonLabel14.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel14.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel14.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel14.TabIndex = 32;
            kryptonLabel14.Values.Text = "Stanowisko:";
            // 
            // kryptonLabel15
            // 
            kryptonLabel15.Location = new Point(665, 431);
            kryptonLabel15.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel15.Name = "kryptonLabel15";
            kryptonLabel15.Size = new Size(54, 18);
            kryptonLabel15.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel15.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel15.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel15.TabIndex = 34;
            kryptonLabel15.Values.Text = "Pensja:";
            // 
            // nudSalary
            // 
            nudSalary.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            nudSalary.Location = new Point(665, 448);
            nudSalary.Margin = new Padding(3, 2, 3, 2);
            nudSalary.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudSalary.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            nudSalary.Name = "nudSalary";
            nudSalary.Size = new Size(149, 30);
            nudSalary.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            nudSalary.StateCommon.Border.Rounding = 12.5F;
            nudSalary.StateCommon.Border.Width = 1;
            nudSalary.TabIndex = 33;
            nudSalary.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // chkIsActive
            // 
            chkIsActive.Location = new Point(1102, 490);
            chkIsActive.Margin = new Padding(3, 2, 3, 2);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(102, 23);
            chkIsActive.StateCommon.ShortText.Color1 = Color.White;
            chkIsActive.StateCommon.ShortText.Color2 = Color.White;
            chkIsActive.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            chkIsActive.TabIndex = 35;
            chkIsActive.Values.Text = "aktywność";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1060, 416);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.OverrideDefault.Back.Color1 = Color.FromArgb(23, 35, 49);
            btnUpdate.OverrideDefault.Back.Color2 = Color.FromArgb(23, 35, 49);
            btnUpdate.OverrideDefault.Back.ColorAngle = 45F;
            btnUpdate.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnUpdate.OverrideDefault.Border.Color1 = Color.FromArgb(23, 35, 49);
            btnUpdate.OverrideDefault.Border.Color2 = Color.FromArgb(23, 35, 49);
            btnUpdate.OverrideDefault.Border.ColorAngle = 45F;
            btnUpdate.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnUpdate.OverrideDefault.Border.Rounding = 12.5F;
            btnUpdate.OverrideDefault.Border.Width = 1;
            btnUpdate.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnUpdate.Size = new Size(158, 23);
            btnUpdate.StateCommon.Back.Color1 = Color.FromArgb(23, 35, 49);
            btnUpdate.StateCommon.Back.Color2 = Color.FromArgb(23, 35, 49);
            btnUpdate.StateCommon.Back.ColorAngle = 45F;
            btnUpdate.StateCommon.Border.Color1 = Color.FromArgb(23, 35, 49);
            btnUpdate.StateCommon.Border.Color2 = Color.FromArgb(23, 35, 49);
            btnUpdate.StateCommon.Border.ColorAngle = 45F;
            btnUpdate.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnUpdate.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnUpdate.StateCommon.Border.Rounding = 12.5F;
            btnUpdate.StateCommon.Border.Width = 1;
            btnUpdate.StateCommon.Content.ShortText.Color1 = Color.White;
            btnUpdate.StateCommon.Content.ShortText.Color2 = Color.White;
            btnUpdate.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnUpdate.StatePressed.Back.Color1 = Color.FromArgb(0, 189, 241);
            btnUpdate.StatePressed.Back.Color2 = Color.FromArgb(0, 189, 241);
            btnUpdate.StatePressed.Back.ColorAngle = 130F;
            btnUpdate.StatePressed.Border.Color1 = Color.FromArgb(0, 189, 241);
            btnUpdate.StatePressed.Border.Color2 = Color.FromArgb(0, 189, 241);
            btnUpdate.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnUpdate.StatePressed.Border.Rounding = 12.5F;
            btnUpdate.StatePressed.Border.Width = 1;
            btnUpdate.StateTracking.Back.Color1 = Color.FromArgb(0, 189, 241);
            btnUpdate.StateTracking.Back.ColorAngle = 45F;
            btnUpdate.StateTracking.Border.Color1 = Color.FromArgb(0, 189, 241);
            btnUpdate.StateTracking.Border.Color2 = Color.FromArgb(0, 189, 241);
            btnUpdate.StateTracking.Border.ColorAngle = 45F;
            btnUpdate.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnUpdate.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnUpdate.StateTracking.Border.Rounding = 12.5F;
            btnUpdate.StateTracking.Border.Width = 1;
            btnUpdate.TabIndex = 36;
            btnUpdate.Values.Text = "Zmień";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // kryptonLabel16
            // 
            kryptonLabel16.Location = new Point(27, 495);
            kryptonLabel16.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel16.Name = "kryptonLabel16";
            kryptonLabel16.Size = new Size(46, 18);
            kryptonLabel16.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel16.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel16.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel16.TabIndex = 38;
            kryptonLabel16.Values.Text = "Pesel:";
            // 
            // txtPesel
            // 
            txtPesel.Location = new Point(27, 515);
            txtPesel.Margin = new Padding(3, 2, 3, 2);
            txtPesel.Name = "txtPesel";
            txtPesel.Size = new Size(153, 26);
            txtPesel.StateCommon.Back.Color1 = Color.White;
            txtPesel.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPesel.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtPesel.StateCommon.Border.Rounding = 12.5F;
            txtPesel.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtPesel.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtPesel.TabIndex = 37;
            // 
            // chkIsTerminationDate
            // 
            chkIsTerminationDate.Location = new Point(819, 545);
            chkIsTerminationDate.Margin = new Padding(3, 2, 3, 2);
            chkIsTerminationDate.Name = "chkIsTerminationDate";
            chkIsTerminationDate.Size = new Size(76, 16);
            chkIsTerminationDate.StateCommon.ShortText.Color1 = Color.White;
            chkIsTerminationDate.StateCommon.ShortText.Color2 = Color.White;
            chkIsTerminationDate.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            chkIsTerminationDate.TabIndex = 39;
            chkIsTerminationDate.Values.Text = "Wpisz datę";
            chkIsTerminationDate.CheckedChanged += chkIsTerminationDate_CheckedChanged;
            // 
            // FormEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 57, 76);
            ClientSize = new Size(1246, 592);
            Controls.Add(chkIsTerminationDate);
            Controls.Add(kryptonLabel16);
            Controls.Add(txtPesel);
            Controls.Add(btnUpdate);
            Controls.Add(chkIsActive);
            Controls.Add(kryptonLabel15);
            Controls.Add(nudSalary);
            Controls.Add(kryptonLabel14);
            Controls.Add(kryptonLabel13);
            Controls.Add(cmbPosition);
            Controls.Add(cmbDepartment);
            Controls.Add(kryptonLabel12);
            Controls.Add(kryptonLabel11);
            Controls.Add(kryptonLabel10);
            Controls.Add(kryptonLabel9);
            Controls.Add(dtpTerminationDate);
            Controls.Add(dtpEmploymentDate);
            Controls.Add(nudHouseNumber);
            Controls.Add(nudApartmentNumber);
            Controls.Add(kryptonLabel8);
            Controls.Add(txtStreet);
            Controls.Add(kryptonLabel7);
            Controls.Add(txtPostalCode);
            Controls.Add(kryptonLabel6);
            Controls.Add(txtCity);
            Controls.Add(kryptonLabel5);
            Controls.Add(txtPhone);
            Controls.Add(kryptonLabel4);
            Controls.Add(txtEmail);
            Controls.Add(kryptonLabel3);
            Controls.Add(txtLastName);
            Controls.Add(kryptonLabel2);
            Controls.Add(txtFirstName);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(kryptonLabel1);
            Controls.Add(txtSearch);
            Controls.Add(dgvEmployees);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEmployee";
            Text = "`";
            Load += FormEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbDepartment).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbPosition).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Krypton.Toolkit.KryptonDataGridView dgvEmployees;
        private Krypton.Toolkit.KryptonTextBox txtSearch;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton btnSearch;
        private Krypton.Toolkit.KryptonButton btnAdd;
        private Krypton.Toolkit.KryptonButton btnDelete;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txtFirstName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox txtLastName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonTextBox txtEmail;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonTextBox txtPhone;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonTextBox txtCity;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonTextBox txtPostalCode;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonTextBox txtStreet;
        private Krypton.Toolkit.KryptonNumericUpDown nudApartmentNumber;
        private Krypton.Toolkit.KryptonNumericUpDown nudHouseNumber;
        private Krypton.Toolkit.KryptonDateTimePicker dtpEmploymentDate;
        private Krypton.Toolkit.KryptonDateTimePicker dtpTerminationDate;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private Krypton.Toolkit.KryptonComboBox cmbDepartment;
        private Krypton.Toolkit.KryptonComboBox cmbPosition;
        private Krypton.Toolkit.KryptonLabel kryptonLabel13;
        private Krypton.Toolkit.KryptonLabel kryptonLabel14;
        private Krypton.Toolkit.KryptonLabel kryptonLabel15;
        private Krypton.Toolkit.KryptonNumericUpDown nudSalary;
        private Krypton.Toolkit.KryptonCheckBox chkIsActive;
        private Krypton.Toolkit.KryptonButton btnUpdate;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Pesel;
        private DataGridViewTextBoxColumn Street;
        private DataGridViewTextBoxColumn HouseNumber;
        private DataGridViewTextBoxColumn ApartmentNumber;
        private DataGridViewTextBoxColumn PostalCode;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewCheckBoxColumn IsActive;
        private DataGridViewTextBoxColumn EmploymentDate;
        private DataGridViewTextBoxColumn TerminationDate;
        private DataGridViewTextBoxColumn Salary;
        private DataGridViewTextBoxColumn DepartmentName;
        private DataGridViewTextBoxColumn PositionName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel16;
        private Krypton.Toolkit.KryptonTextBox txtPesel;
        private Krypton.Toolkit.KryptonCheckBox chkIsTerminationDate;
    }
}