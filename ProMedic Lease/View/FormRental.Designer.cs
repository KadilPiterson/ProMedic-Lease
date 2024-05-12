namespace ProMedic_Lease.View
{
    partial class FormRental
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvRental = new Krypton.Toolkit.KryptonDataGridView();
            btnUpdate = new Krypton.Toolkit.KryptonButton();
            btnDelete = new Krypton.Toolkit.KryptonButton();
            btnAdd = new Krypton.Toolkit.KryptonButton();
            btnSearch = new Krypton.Toolkit.KryptonButton();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            txtSearch = new Krypton.Toolkit.KryptonTextBox();
            cobEquipment = new Krypton.Toolkit.KryptonLabel();
            cmbEquipment = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            cmbClient = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            dtpStartDate = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            dtpEndDate = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            cmbEmployee = new Krypton.Toolkit.KryptonComboBox();
            chkIsEndDate = new Krypton.Toolkit.KryptonCheckBox();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            txtComment = new Krypton.Toolkit.KryptonTextBox();
            chkIsActive = new Krypton.Toolkit.KryptonCheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvRental).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbEquipment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbClient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbEmployee).BeginInit();
            SuspendLayout();
            // 
            // dgvRental
            // 
            dgvRental.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRental.BorderStyle = BorderStyle.None;
            dgvRental.ColumnHeadersHeight = 36;
            dgvRental.Location = new Point(11, 57);
            dgvRental.Margin = new Padding(3, 2, 3, 2);
            dgvRental.Name = "dgvRental";
            dgvRental.ReadOnly = true;
            dgvRental.RowHeadersWidth = 51;
            dgvRental.Size = new Size(1193, 352);
            dgvRental.StateCommon.Background.Color1 = Color.FromArgb(41, 57, 76);
            dgvRental.StateCommon.Background.Color2 = Color.FromArgb(41, 57, 76);
            dgvRental.StateCommon.Background.ColorAngle = 45F;
            dgvRental.StateCommon.Background.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            dgvRental.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvRental.StateCommon.DataCell.Back.Color1 = Color.FromArgb(41, 57, 76);
            dgvRental.StateCommon.DataCell.Back.Color2 = Color.FromArgb(41, 57, 76);
            dgvRental.StateCommon.DataCell.Border.Color1 = Color.FromArgb(0, 189, 241);
            dgvRental.StateCommon.DataCell.Border.Color2 = Color.FromArgb(0, 189, 241);
            dgvRental.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dgvRental.StateCommon.DataCell.Content.Color1 = Color.White;
            dgvRental.StateCommon.DataCell.Content.Color2 = Color.White;
            dgvRental.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(23, 35, 49);
            dgvRental.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(23, 35, 49);
            dgvRental.StateCommon.HeaderColumn.Border.Color1 = Color.FromArgb(0, 189, 241);
            dgvRental.StateCommon.HeaderColumn.Border.Color2 = Color.FromArgb(0, 189, 241);
            dgvRental.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dgvRental.StateCommon.HeaderColumn.Content.Color1 = Color.White;
            dgvRental.StateCommon.HeaderColumn.Content.Color2 = Color.White;
            dgvRental.StateCommon.HeaderColumn.Content.ColorAngle = 45F;
            dgvRental.StateCommon.HeaderColumn.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dgvRental.StateCommon.HeaderRow.Back.Color1 = Color.FromArgb(41, 57, 76);
            dgvRental.StateCommon.HeaderRow.Back.Color2 = Color.FromArgb(41, 57, 76);
            dgvRental.StateCommon.HeaderRow.Border.Color1 = Color.FromArgb(0, 189, 241);
            dgvRental.StateCommon.HeaderRow.Border.Color2 = Color.FromArgb(0, 189, 241);
            dgvRental.StateCommon.HeaderRow.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dgvRental.StateCommon.HeaderRow.Content.Color1 = Color.White;
            dgvRental.StateCommon.HeaderRow.Content.Color2 = Color.White;
            dgvRental.TabIndex = 54;
            dgvRental.SelectionChanged += dgvRental_SelectionChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1046, 413);
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
            btnUpdate.TabIndex = 60;
            btnUpdate.Values.Text = "Zmień";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1046, 29);
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
            btnDelete.TabIndex = 59;
            btnDelete.Values.Text = "Usuń";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(884, 29);
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
            btnAdd.TabIndex = 58;
            btnAdd.Values.Text = "Dodaj";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(172, 29);
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
            btnSearch.TabIndex = 57;
            btnSearch.Values.Text = "Wyszukaj";
            btnSearch.Click += btnSearch_Click;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(13, 10);
            kryptonLabel1.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(69, 18);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel1.TabIndex = 56;
            kryptonLabel1.Values.Text = "Wyszukaj:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(13, 30);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(153, 26);
            txtSearch.StateCommon.Back.Color1 = Color.White;
            txtSearch.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSearch.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtSearch.StateCommon.Border.Rounding = 12.5F;
            txtSearch.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtSearch.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtSearch.TabIndex = 55;
            // 
            // cobEquipment
            // 
            cobEquipment.Location = new Point(13, 426);
            cobEquipment.Margin = new Padding(3, 2, 3, 2);
            cobEquipment.Name = "cobEquipment";
            cobEquipment.Size = new Size(51, 18);
            cobEquipment.StateCommon.ShortText.Color1 = Color.White;
            cobEquipment.StateCommon.ShortText.Color2 = Color.White;
            cobEquipment.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            cobEquipment.TabIndex = 62;
            cobEquipment.Values.Text = "Sprzęt:";
            // 
            // cmbEquipment
            // 
            cmbEquipment.DropDownWidth = 151;
            cmbEquipment.IntegralHeight = false;
            cmbEquipment.Location = new Point(13, 443);
            cmbEquipment.Margin = new Padding(3, 2, 3, 2);
            cmbEquipment.Name = "cmbEquipment";
            cmbEquipment.Size = new Size(139, 29);
            cmbEquipment.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbEquipment.StateCommon.ComboBox.Border.Rounding = 12.5F;
            cmbEquipment.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbEquipment.StateCommon.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cmbEquipment.TabIndex = 61;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(158, 426);
            kryptonLabel2.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(47, 18);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel2.TabIndex = 64;
            kryptonLabel2.Values.Text = "Klient:";
            // 
            // cmbClient
            // 
            cmbClient.DropDownWidth = 151;
            cmbClient.IntegralHeight = false;
            cmbClient.Location = new Point(158, 443);
            cmbClient.Margin = new Padding(3, 2, 3, 2);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new Size(139, 29);
            cmbClient.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbClient.StateCommon.ComboBox.Border.Rounding = 12.5F;
            cmbClient.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbClient.StateCommon.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cmbClient.TabIndex = 63;
            // 
            // kryptonLabel11
            // 
            kryptonLabel11.Location = new Point(447, 426);
            kryptonLabel11.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel11.Name = "kryptonLabel11";
            kryptonLabel11.Size = new Size(113, 18);
            kryptonLabel11.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel11.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel11.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel11.TabIndex = 66;
            kryptonLabel11.Values.Text = "Data rozpoczęcia:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(447, 443);
            dtpStartDate.Margin = new Padding(3, 2, 3, 2);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(139, 26);
            dtpStartDate.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpStartDate.StateCommon.Border.Rounding = 12.5F;
            dtpStartDate.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dtpStartDate.TabIndex = 65;
            dtpStartDate.ValueNullable = new DateTime(2024, 1, 1, 19, 52, 0, 0);
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(592, 426);
            kryptonLabel3.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(116, 18);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel3.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel3.TabIndex = 68;
            kryptonLabel3.Values.Text = "Data zakończenia:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(592, 443);
            dtpEndDate.Margin = new Padding(3, 2, 3, 2);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(139, 26);
            dtpEndDate.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpEndDate.StateCommon.Border.Rounding = 12.5F;
            dtpEndDate.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dtpEndDate.TabIndex = 67;
            dtpEndDate.ValueNullable = new DateTime(2024, 1, 1, 19, 52, 0, 0);
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(302, 426);
            kryptonLabel4.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(73, 18);
            kryptonLabel4.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel4.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel4.TabIndex = 70;
            kryptonLabel4.Values.Text = "Pracownik:";
            // 
            // cmbEmployee
            // 
            cmbEmployee.DropDownWidth = 151;
            cmbEmployee.IntegralHeight = false;
            cmbEmployee.Location = new Point(302, 443);
            cmbEmployee.Margin = new Padding(3, 2, 3, 2);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(139, 29);
            cmbEmployee.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbEmployee.StateCommon.ComboBox.Border.Rounding = 12.5F;
            cmbEmployee.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbEmployee.StateCommon.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cmbEmployee.TabIndex = 69;
            // 
            // chkIsEndDate
            // 
            chkIsEndDate.Location = new Point(592, 470);
            chkIsEndDate.Margin = new Padding(3, 2, 3, 2);
            chkIsEndDate.Name = "chkIsEndDate";
            chkIsEndDate.Size = new Size(76, 16);
            chkIsEndDate.StateCommon.ShortText.Color1 = Color.White;
            chkIsEndDate.StateCommon.ShortText.Color2 = Color.White;
            chkIsEndDate.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            chkIsEndDate.TabIndex = 71;
            chkIsEndDate.Values.Text = "Wpisz datę";
            chkIsEndDate.CheckedChanged += chkIsEndDate_CheckedChanged;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(736, 426);
            kryptonLabel5.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(50, 18);
            kryptonLabel5.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel5.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel5.TabIndex = 73;
            kryptonLabel5.Values.Text = "Uwagi:";
            // 
            // txtComment
            // 
            txtComment.Location = new Point(736, 442);
            txtComment.Margin = new Padding(3, 2, 3, 2);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(153, 26);
            txtComment.StateCommon.Back.Color1 = Color.White;
            txtComment.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtComment.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtComment.StateCommon.Border.Rounding = 12.5F;
            txtComment.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtComment.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtComment.TabIndex = 72;
            // 
            // chkIsActive
            // 
            chkIsActive.Enabled = false;
            chkIsActive.Location = new Point(894, 443);
            chkIsActive.Margin = new Padding(3, 2, 3, 2);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(72, 23);
            chkIsActive.StateCommon.ShortText.Color1 = Color.White;
            chkIsActive.StateCommon.ShortText.Color2 = Color.White;
            chkIsActive.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            chkIsActive.TabIndex = 74;
            chkIsActive.Values.Text = "Status";
            // 
            // FormRental
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 57, 76);
            ClientSize = new Size(1214, 522);
            Controls.Add(chkIsActive);
            Controls.Add(kryptonLabel5);
            Controls.Add(txtComment);
            Controls.Add(chkIsEndDate);
            Controls.Add(kryptonLabel4);
            Controls.Add(cmbEmployee);
            Controls.Add(kryptonLabel3);
            Controls.Add(dtpEndDate);
            Controls.Add(kryptonLabel11);
            Controls.Add(dtpStartDate);
            Controls.Add(kryptonLabel2);
            Controls.Add(cmbClient);
            Controls.Add(cobEquipment);
            Controls.Add(cmbEquipment);
            Controls.Add(dgvRental);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(kryptonLabel1);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormRental";
            Load += FormRental_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRental).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbEquipment).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbClient).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgvRental;
        private Krypton.Toolkit.KryptonButton btnUpdate;
        private Krypton.Toolkit.KryptonButton btnDelete;
        private Krypton.Toolkit.KryptonButton btnAdd;
        private Krypton.Toolkit.KryptonButton btnSearch;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox txtSearch;
        private Krypton.Toolkit.KryptonLabel cobEquipment;
        private Krypton.Toolkit.KryptonComboBox cmbEquipment;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonComboBox cmbClient;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonDateTimePicker dtpStartDate;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonDateTimePicker dtpEndDate;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonComboBox cmbEmployee;
        private Krypton.Toolkit.KryptonCheckBox chkIsEndDate;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonTextBox txtComment;
        private Krypton.Toolkit.KryptonCheckBox chkIsActive;
    }
}