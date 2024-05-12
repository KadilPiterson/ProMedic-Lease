namespace ProMedic_Lease.View
{
    partial class FormMaintenanceHistory
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
            btnUpdate = new Krypton.Toolkit.KryptonButton();
            btnDelete = new Krypton.Toolkit.KryptonButton();
            btnAdd = new Krypton.Toolkit.KryptonButton();
            btnSearch = new Krypton.Toolkit.KryptonButton();
            txtSearch = new Krypton.Toolkit.KryptonTextBox();
            dgvMaintenanceHistory = new Krypton.Toolkit.KryptonDataGridView();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel13 = new Krypton.Toolkit.KryptonLabel();
            cmbEquipment = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel15 = new Krypton.Toolkit.KryptonLabel();
            nudCost = new Krypton.Toolkit.KryptonNumericUpDown();
            dtpDateStart = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            dtpDateEnd = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            txtComment = new Krypton.Toolkit.KryptonTextBox();
            chkIsActive = new Krypton.Toolkit.KryptonCheckBox();
            chkEndDate = new Krypton.Toolkit.KryptonCheckBox();
            cmbEmployee = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvMaintenanceHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbEquipment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbEmployee).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1044, 413);
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
            btnUpdate.TabIndex = 42;
            btnUpdate.Values.Text = "Zmień";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1044, 29);
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
            btnDelete.TabIndex = 41;
            btnDelete.Values.Text = "Usuń";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(881, 29);
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
            btnAdd.TabIndex = 40;
            btnAdd.Values.Text = "Dodaj";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(169, 29);
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
            btnSearch.TabIndex = 39;
            btnSearch.Values.Text = "Wyszukaj";
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(10, 30);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(153, 26);
            txtSearch.StateCommon.Back.Color1 = Color.White;
            txtSearch.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSearch.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtSearch.StateCommon.Border.Rounding = 12.5F;
            txtSearch.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtSearch.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtSearch.TabIndex = 38;
            // 
            // dgvMaintenanceHistory
            // 
            dgvMaintenanceHistory.AllowUserToOrderColumns = true;
            dgvMaintenanceHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaintenanceHistory.BorderStyle = BorderStyle.None;
            dgvMaintenanceHistory.ColumnHeadersHeight = 36;
            dgvMaintenanceHistory.Location = new Point(10, 57);
            dgvMaintenanceHistory.Margin = new Padding(3, 2, 3, 2);
            dgvMaintenanceHistory.Name = "dgvMaintenanceHistory";
            dgvMaintenanceHistory.ReadOnly = true;
            dgvMaintenanceHistory.RowHeadersWidth = 51;
            dgvMaintenanceHistory.Size = new Size(1193, 352);
            dgvMaintenanceHistory.StateCommon.Background.Color1 = Color.FromArgb(41, 57, 76);
            dgvMaintenanceHistory.StateCommon.Background.Color2 = Color.FromArgb(41, 57, 76);
            dgvMaintenanceHistory.StateCommon.Background.ColorAngle = 45F;
            dgvMaintenanceHistory.StateCommon.Background.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            dgvMaintenanceHistory.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvMaintenanceHistory.StateCommon.DataCell.Back.Color1 = Color.FromArgb(41, 57, 76);
            dgvMaintenanceHistory.StateCommon.DataCell.Back.Color2 = Color.FromArgb(41, 57, 76);
            dgvMaintenanceHistory.StateCommon.DataCell.Border.Color1 = Color.FromArgb(0, 189, 241);
            dgvMaintenanceHistory.StateCommon.DataCell.Border.Color2 = Color.FromArgb(0, 189, 241);
            dgvMaintenanceHistory.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dgvMaintenanceHistory.StateCommon.DataCell.Content.Color1 = Color.White;
            dgvMaintenanceHistory.StateCommon.DataCell.Content.Color2 = Color.White;
            dgvMaintenanceHistory.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(23, 35, 49);
            dgvMaintenanceHistory.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(23, 35, 49);
            dgvMaintenanceHistory.StateCommon.HeaderColumn.Border.Color1 = Color.FromArgb(0, 189, 241);
            dgvMaintenanceHistory.StateCommon.HeaderColumn.Border.Color2 = Color.FromArgb(0, 189, 241);
            dgvMaintenanceHistory.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dgvMaintenanceHistory.StateCommon.HeaderColumn.Content.Color1 = Color.White;
            dgvMaintenanceHistory.StateCommon.HeaderColumn.Content.Color2 = Color.White;
            dgvMaintenanceHistory.StateCommon.HeaderColumn.Content.ColorAngle = 45F;
            dgvMaintenanceHistory.StateCommon.HeaderColumn.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dgvMaintenanceHistory.StateCommon.HeaderRow.Back.Color1 = Color.FromArgb(41, 57, 76);
            dgvMaintenanceHistory.StateCommon.HeaderRow.Back.Color2 = Color.FromArgb(41, 57, 76);
            dgvMaintenanceHistory.StateCommon.HeaderRow.Border.Color1 = Color.FromArgb(0, 189, 241);
            dgvMaintenanceHistory.StateCommon.HeaderRow.Border.Color2 = Color.FromArgb(0, 189, 241);
            dgvMaintenanceHistory.StateCommon.HeaderRow.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dgvMaintenanceHistory.StateCommon.HeaderRow.Content.Color1 = Color.White;
            dgvMaintenanceHistory.StateCommon.HeaderRow.Content.Color2 = Color.White;
            dgvMaintenanceHistory.TabIndex = 37;
            dgvMaintenanceHistory.SelectionChanged += dgvMaintenanceHistory_SelectionChanged;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(10, 10);
            kryptonLabel1.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(69, 18);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel1.TabIndex = 43;
            kryptonLabel1.Values.Text = "Wyszukaj:";
            // 
            // kryptonLabel13
            // 
            kryptonLabel13.Location = new Point(38, 446);
            kryptonLabel13.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel13.Name = "kryptonLabel13";
            kryptonLabel13.Size = new Size(51, 18);
            kryptonLabel13.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel13.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel13.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel13.TabIndex = 51;
            kryptonLabel13.Values.Text = "Sprzęt:";
            // 
            // cmbEquipment
            // 
            cmbEquipment.DropDownWidth = 151;
            cmbEquipment.IntegralHeight = false;
            cmbEquipment.Location = new Point(38, 463);
            cmbEquipment.Margin = new Padding(3, 2, 3, 2);
            cmbEquipment.Name = "cmbEquipment";
            cmbEquipment.Size = new Size(149, 29);
            cmbEquipment.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbEquipment.StateCommon.ComboBox.Border.Rounding = 12.5F;
            cmbEquipment.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbEquipment.StateCommon.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cmbEquipment.TabIndex = 50;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(192, 446);
            kryptonLabel2.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(73, 18);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel2.TabIndex = 53;
            kryptonLabel2.Values.Text = "Pracownik:";
            // 
            // kryptonLabel15
            // 
            kryptonLabel15.Location = new Point(663, 442);
            kryptonLabel15.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel15.Name = "kryptonLabel15";
            kryptonLabel15.Size = new Size(98, 18);
            kryptonLabel15.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel15.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel15.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel15.TabIndex = 55;
            kryptonLabel15.Values.Text = "Koszt naprawy:";
            // 
            // nudCost
            // 
            nudCost.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            nudCost.Location = new Point(663, 459);
            nudCost.Margin = new Padding(3, 2, 3, 2);
            nudCost.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudCost.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            nudCost.Name = "nudCost";
            nudCost.Size = new Size(149, 30);
            nudCost.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            nudCost.StateCommon.Border.Rounding = 12.5F;
            nudCost.StateCommon.Border.Width = 1;
            nudCost.TabIndex = 54;
            nudCost.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // dtpDateStart
            // 
            dtpDateStart.Location = new Point(346, 463);
            dtpDateStart.Margin = new Padding(3, 2, 3, 2);
            dtpDateStart.Name = "dtpDateStart";
            dtpDateStart.Size = new Size(153, 26);
            dtpDateStart.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDateStart.StateCommon.Border.Rounding = 12.5F;
            dtpDateStart.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dtpDateStart.TabIndex = 78;
            // 
            // kryptonLabel11
            // 
            kryptonLabel11.Location = new Point(346, 446);
            kryptonLabel11.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel11.Name = "kryptonLabel11";
            kryptonLabel11.Size = new Size(113, 18);
            kryptonLabel11.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel11.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel11.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel11.TabIndex = 77;
            kryptonLabel11.Values.Text = "Data rozpoczęcia:";
            // 
            // dtpDateEnd
            // 
            dtpDateEnd.Location = new Point(505, 463);
            dtpDateEnd.Margin = new Padding(3, 2, 3, 2);
            dtpDateEnd.Name = "dtpDateEnd";
            dtpDateEnd.Size = new Size(153, 26);
            dtpDateEnd.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDateEnd.StateCommon.Border.Rounding = 12.5F;
            dtpDateEnd.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dtpDateEnd.TabIndex = 80;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(505, 446);
            kryptonLabel3.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(116, 18);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel3.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel3.TabIndex = 79;
            kryptonLabel3.Values.Text = "Data zakończenia:";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(817, 446);
            kryptonLabel5.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(41, 18);
            kryptonLabel5.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel5.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel5.TabIndex = 82;
            kryptonLabel5.Values.Text = "Opis:";
            // 
            // txtComment
            // 
            txtComment.Location = new Point(817, 463);
            txtComment.Margin = new Padding(3, 2, 3, 2);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(153, 26);
            txtComment.StateCommon.Back.Color1 = Color.White;
            txtComment.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtComment.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtComment.StateCommon.Border.Rounding = 12.5F;
            txtComment.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtComment.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtComment.TabIndex = 81;
            // 
            // chkIsActive
            // 
            chkIsActive.Enabled = false;
            chkIsActive.Location = new Point(984, 464);
            chkIsActive.Margin = new Padding(3, 2, 3, 2);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(72, 23);
            chkIsActive.StateCommon.ShortText.Color1 = Color.White;
            chkIsActive.StateCommon.ShortText.Color2 = Color.White;
            chkIsActive.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            chkIsActive.TabIndex = 83;
            chkIsActive.Values.Text = "Status";
            // 
            // chkEndDate
            // 
            chkEndDate.Location = new Point(505, 493);
            chkEndDate.Margin = new Padding(3, 2, 3, 2);
            chkEndDate.Name = "chkEndDate";
            chkEndDate.Size = new Size(76, 16);
            chkEndDate.StateCommon.ShortText.Color1 = Color.White;
            chkEndDate.StateCommon.ShortText.Color2 = Color.White;
            chkEndDate.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            chkEndDate.TabIndex = 84;
            chkEndDate.Values.Text = "Wpisz datę";
            chkEndDate.CheckedChanged += chkDisposalDate_CheckedChanged;
            // 
            // cmbEmployee
            // 
            cmbEmployee.DropDownWidth = 151;
            cmbEmployee.IntegralHeight = false;
            cmbEmployee.Location = new Point(191, 464);
            cmbEmployee.Margin = new Padding(3, 2, 3, 2);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(149, 29);
            cmbEmployee.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbEmployee.StateCommon.ComboBox.Border.Rounding = 12.5F;
            cmbEmployee.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbEmployee.StateCommon.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cmbEmployee.TabIndex = 86;
            // 
            // FormMaintenanceHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 57, 76);
            ClientSize = new Size(1246, 592);
            Controls.Add(cmbEmployee);
            Controls.Add(chkEndDate);
            Controls.Add(chkIsActive);
            Controls.Add(kryptonLabel5);
            Controls.Add(txtComment);
            Controls.Add(dtpDateEnd);
            Controls.Add(kryptonLabel3);
            Controls.Add(dtpDateStart);
            Controls.Add(kryptonLabel11);
            Controls.Add(kryptonLabel15);
            Controls.Add(nudCost);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel13);
            Controls.Add(cmbEquipment);
            Controls.Add(kryptonLabel1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvMaintenanceHistory);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMaintenanceHistory";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "FormMaintenanceHistory";
            Load += FormMaintenanceHistory_Load;
            VisibleChanged += FormMaintenanceHistory_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)dgvMaintenanceHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbEquipment).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnUpdate;
        private Krypton.Toolkit.KryptonButton btnDelete;
        private Krypton.Toolkit.KryptonButton btnAdd;
        private Krypton.Toolkit.KryptonButton btnSearch;
        private Krypton.Toolkit.KryptonTextBox txtSearch;
        private Krypton.Toolkit.KryptonDataGridView dgvMaintenanceHistory;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel13;
        private Krypton.Toolkit.KryptonComboBox cmbEquipment;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel15;
        private Krypton.Toolkit.KryptonNumericUpDown nudCost;
        private Krypton.Toolkit.KryptonDateTimePicker dtpDateStart;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonDateTimePicker dtpDateEnd;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonTextBox txtComment;
        private Krypton.Toolkit.KryptonCheckBox chkIsActive;
        private Krypton.Toolkit.KryptonCheckBox chkEndDate;
        private Krypton.Toolkit.KryptonComboBox cmbEmployee;
    }
}