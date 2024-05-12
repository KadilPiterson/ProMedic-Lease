namespace ProMedic_Lease.View
{
    partial class FormEquipment
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
            dgvMaintenanceHistory = new Krypton.Toolkit.KryptonDataGridView();
            btnUpdate = new Krypton.Toolkit.KryptonButton();
            kryptonLabel15 = new Krypton.Toolkit.KryptonLabel();
            nudDailyRentalPrice = new Krypton.Toolkit.KryptonNumericUpDown();
            kryptonLabel13 = new Krypton.Toolkit.KryptonLabel();
            cmbEquipmentType = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            dtpPurchaseDate = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            txtInvoiceNumber = new Krypton.Toolkit.KryptonTextBox();
            btnDelete = new Krypton.Toolkit.KryptonButton();
            btnAdd = new Krypton.Toolkit.KryptonButton();
            btnSearch = new Krypton.Toolkit.KryptonButton();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            txtSearch = new Krypton.Toolkit.KryptonTextBox();
            kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            txtName = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            txtInventoryNumber = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            txtIdentificationNumber = new Krypton.Toolkit.KryptonTextBox();
            chkIsServiced = new Krypton.Toolkit.KryptonCheckBox();
            chkIsInTransit = new Krypton.Toolkit.KryptonCheckBox();
            chkDisposalDate = new Krypton.Toolkit.KryptonCheckBox();
            kryptonLabel12 = new Krypton.Toolkit.KryptonLabel();
            dtpDisposalDate = new Krypton.Toolkit.KryptonDateTimePicker();
            chkStatus = new Krypton.Toolkit.KryptonCheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvMaintenanceHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbEquipmentType).BeginInit();
            SuspendLayout();
            // 
            // dgvMaintenanceHistory
            // 
            dgvMaintenanceHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMaintenanceHistory.BorderStyle = BorderStyle.None;
            dgvMaintenanceHistory.ColumnHeadersHeight = 36;
            dgvMaintenanceHistory.Location = new Point(10, 62);
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
            dgvMaintenanceHistory.TabIndex = 1;
            dgvMaintenanceHistory.SelectionChanged += dgvEquipment_SelectionChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1045, 418);
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
            btnUpdate.TabIndex = 53;
            btnUpdate.Values.Text = "Zmień";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // kryptonLabel15
            // 
            kryptonLabel15.Location = new Point(472, 475);
            kryptonLabel15.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel15.Name = "kryptonLabel15";
            kryptonLabel15.Size = new Size(130, 18);
            kryptonLabel15.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel15.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel15.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel15.TabIndex = 51;
            kryptonLabel15.Values.Text = "Koszt wypożyczenia:";
            // 
            // nudDailyRentalPrice
            // 
            nudDailyRentalPrice.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            nudDailyRentalPrice.Location = new Point(472, 492);
            nudDailyRentalPrice.Margin = new Padding(3, 2, 3, 2);
            nudDailyRentalPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudDailyRentalPrice.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            nudDailyRentalPrice.Name = "nudDailyRentalPrice";
            nudDailyRentalPrice.Size = new Size(149, 30);
            nudDailyRentalPrice.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            nudDailyRentalPrice.StateCommon.Border.Rounding = 12.5F;
            nudDailyRentalPrice.StateCommon.Border.Width = 1;
            nudDailyRentalPrice.TabIndex = 50;
            nudDailyRentalPrice.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // kryptonLabel13
            // 
            kryptonLabel13.Location = new Point(472, 431);
            kryptonLabel13.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel13.Name = "kryptonLabel13";
            kryptonLabel13.Size = new Size(81, 18);
            kryptonLabel13.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel13.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel13.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel13.TabIndex = 49;
            kryptonLabel13.Values.Text = "Typ sprzętu:";
            // 
            // cmbEquipmentType
            // 
            cmbEquipmentType.DropDownWidth = 151;
            cmbEquipmentType.IntegralHeight = false;
            cmbEquipmentType.Location = new Point(472, 448);
            cmbEquipmentType.Margin = new Padding(3, 2, 3, 2);
            cmbEquipmentType.Name = "cmbEquipmentType";
            cmbEquipmentType.Size = new Size(149, 29);
            cmbEquipmentType.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbEquipmentType.StateCommon.ComboBox.Border.Rounding = 12.5F;
            cmbEquipmentType.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbEquipmentType.StateCommon.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cmbEquipmentType.TabIndex = 48;
            // 
            // kryptonLabel11
            // 
            kryptonLabel11.Location = new Point(328, 431);
            kryptonLabel11.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel11.Name = "kryptonLabel11";
            kryptonLabel11.Size = new Size(86, 18);
            kryptonLabel11.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel11.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel11.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel11.TabIndex = 47;
            kryptonLabel11.Values.Text = "Data zakupu:";
            // 
            // dtpPurchaseDate
            // 
            dtpPurchaseDate.Location = new Point(328, 448);
            dtpPurchaseDate.Margin = new Padding(3, 2, 3, 2);
            dtpPurchaseDate.Name = "dtpPurchaseDate";
            dtpPurchaseDate.Size = new Size(139, 26);
            dtpPurchaseDate.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpPurchaseDate.StateCommon.Border.Rounding = 12.5F;
            dtpPurchaseDate.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dtpPurchaseDate.TabIndex = 45;
            dtpPurchaseDate.ValueNullable = new DateTime(2024, 1, 1, 19, 52, 0, 0);
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(11, 476);
            kryptonLabel5.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(70, 18);
            kryptonLabel5.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel5.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel5.TabIndex = 43;
            kryptonLabel5.Values.Text = "Nr faktury:";
            // 
            // txtInvoiceNumber
            // 
            txtInvoiceNumber.Location = new Point(11, 492);
            txtInvoiceNumber.Margin = new Padding(3, 2, 3, 2);
            txtInvoiceNumber.Name = "txtInvoiceNumber";
            txtInvoiceNumber.Size = new Size(153, 26);
            txtInvoiceNumber.StateCommon.Back.Color1 = Color.White;
            txtInvoiceNumber.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtInvoiceNumber.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtInvoiceNumber.StateCommon.Border.Rounding = 12.5F;
            txtInvoiceNumber.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtInvoiceNumber.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtInvoiceNumber.TabIndex = 42;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1045, 34);
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
            btnAdd.Location = new Point(882, 34);
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
            btnSearch.Location = new Point(170, 34);
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
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(11, 14);
            kryptonLabel1.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(69, 18);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel1.TabIndex = 38;
            kryptonLabel1.Values.Text = "Wyszukaj:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(11, 34);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(153, 26);
            txtSearch.StateCommon.Back.Color1 = Color.White;
            txtSearch.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSearch.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtSearch.StateCommon.Border.Rounding = 12.5F;
            txtSearch.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtSearch.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtSearch.TabIndex = 37;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(11, 431);
            kryptonLabel2.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(53, 18);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel2.TabIndex = 55;
            kryptonLabel2.Values.Text = "Nazwa:";
            // 
            // txtName
            // 
            txtName.Location = new Point(11, 448);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(153, 26);
            txtName.StateCommon.Back.Color1 = Color.White;
            txtName.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtName.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtName.StateCommon.Border.Rounding = 12.5F;
            txtName.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtName.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtName.TabIndex = 54;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(170, 431);
            kryptonLabel3.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(109, 18);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel3.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel3.TabIndex = 57;
            kryptonLabel3.Values.Text = "Nr inwentarzowy:";
            // 
            // txtInventoryNumber
            // 
            txtInventoryNumber.Location = new Point(170, 448);
            txtInventoryNumber.Margin = new Padding(3, 2, 3, 2);
            txtInventoryNumber.Name = "txtInventoryNumber";
            txtInventoryNumber.Size = new Size(153, 26);
            txtInventoryNumber.StateCommon.Back.Color1 = Color.White;
            txtInventoryNumber.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtInventoryNumber.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtInventoryNumber.StateCommon.Border.Rounding = 12.5F;
            txtInventoryNumber.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtInventoryNumber.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtInventoryNumber.TabIndex = 56;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(170, 476);
            kryptonLabel4.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(72, 18);
            kryptonLabel4.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel4.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel4.TabIndex = 59;
            kryptonLabel4.Values.Text = "Nr seryjny:";
            // 
            // txtIdentificationNumber
            // 
            txtIdentificationNumber.Location = new Point(170, 492);
            txtIdentificationNumber.Margin = new Padding(3, 2, 3, 2);
            txtIdentificationNumber.Name = "txtIdentificationNumber";
            txtIdentificationNumber.Size = new Size(153, 26);
            txtIdentificationNumber.StateCommon.Back.Color1 = Color.White;
            txtIdentificationNumber.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtIdentificationNumber.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtIdentificationNumber.StateCommon.Border.Rounding = 12.5F;
            txtIdentificationNumber.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtIdentificationNumber.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtIdentificationNumber.TabIndex = 58;
            // 
            // chkIsServiced
            // 
            chkIsServiced.Enabled = false;
            chkIsServiced.Location = new Point(640, 472);
            chkIsServiced.Margin = new Padding(3, 2, 3, 2);
            chkIsServiced.Name = "chkIsServiced";
            chkIsServiced.Size = new Size(74, 23);
            chkIsServiced.StateCommon.ShortText.Color1 = Color.White;
            chkIsServiced.StateCommon.ShortText.Color2 = Color.White;
            chkIsServiced.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            chkIsServiced.TabIndex = 60;
            chkIsServiced.Values.Text = "Serwis";
            // 
            // chkIsInTransit
            // 
            chkIsInTransit.Location = new Point(640, 446);
            chkIsInTransit.Margin = new Padding(3, 2, 3, 2);
            chkIsInTransit.Name = "chkIsInTransit";
            chkIsInTransit.Size = new Size(89, 23);
            chkIsInTransit.StateCommon.ShortText.Color1 = Color.White;
            chkIsInTransit.StateCommon.ShortText.Color2 = Color.White;
            chkIsInTransit.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            chkIsInTransit.TabIndex = 61;
            chkIsInTransit.Values.Text = "Dostawa";
            // 
            // chkDisposalDate
            // 
            chkDisposalDate.Location = new Point(328, 520);
            chkDisposalDate.Margin = new Padding(3, 2, 3, 2);
            chkDisposalDate.Name = "chkDisposalDate";
            chkDisposalDate.Size = new Size(76, 16);
            chkDisposalDate.StateCommon.ShortText.Color1 = Color.White;
            chkDisposalDate.StateCommon.ShortText.Color2 = Color.White;
            chkDisposalDate.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            chkDisposalDate.TabIndex = 64;
            chkDisposalDate.Values.Text = "Wpisz datę";
            chkDisposalDate.CheckedChanged += chkIsTerminationDate_CheckedChanged;
            // 
            // kryptonLabel12
            // 
            kryptonLabel12.Location = new Point(328, 477);
            kryptonLabel12.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel12.Name = "kryptonLabel12";
            kryptonLabel12.Size = new Size(96, 18);
            kryptonLabel12.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel12.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel12.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel12.TabIndex = 63;
            kryptonLabel12.Values.Text = "Data likwidacji:";
            // 
            // dtpDisposalDate
            // 
            dtpDisposalDate.Location = new Point(328, 494);
            dtpDisposalDate.Margin = new Padding(3, 2, 3, 2);
            dtpDisposalDate.Name = "dtpDisposalDate";
            dtpDisposalDate.Size = new Size(139, 26);
            dtpDisposalDate.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDisposalDate.StateCommon.Border.Rounding = 12.5F;
            dtpDisposalDate.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dtpDisposalDate.TabIndex = 62;
            dtpDisposalDate.ValueNullable = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // chkStatus
            // 
            chkStatus.Enabled = false;
            chkStatus.Location = new Point(640, 497);
            chkStatus.Margin = new Padding(3, 2, 3, 2);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(72, 23);
            chkStatus.StateCommon.ShortText.Color1 = Color.White;
            chkStatus.StateCommon.ShortText.Color2 = Color.White;
            chkStatus.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            chkStatus.TabIndex = 65;
            chkStatus.Values.Text = "Status";
            // 
            // FormEquipment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 57, 76);
            ClientSize = new Size(1230, 557);
            Controls.Add(dgvMaintenanceHistory);
            Controls.Add(chkStatus);
            Controls.Add(chkDisposalDate);
            Controls.Add(kryptonLabel12);
            Controls.Add(dtpDisposalDate);
            Controls.Add(chkIsInTransit);
            Controls.Add(chkIsServiced);
            Controls.Add(kryptonLabel4);
            Controls.Add(txtIdentificationNumber);
            Controls.Add(kryptonLabel3);
            Controls.Add(txtInventoryNumber);
            Controls.Add(kryptonLabel2);
            Controls.Add(txtName);
            Controls.Add(btnUpdate);
            Controls.Add(kryptonLabel15);
            Controls.Add(nudDailyRentalPrice);
            Controls.Add(kryptonLabel13);
            Controls.Add(cmbEquipmentType);
            Controls.Add(kryptonLabel11);
            Controls.Add(dtpPurchaseDate);
            Controls.Add(kryptonLabel5);
            Controls.Add(txtInvoiceNumber);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(kryptonLabel1);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormEquipment";
            ((System.ComponentModel.ISupportInitialize)dgvMaintenanceHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbEquipmentType).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgvMaintenanceHistory;
        private Krypton.Toolkit.KryptonButton btnUpdate;
        private Krypton.Toolkit.KryptonLabel kryptonLabel15;
        private Krypton.Toolkit.KryptonNumericUpDown nudDailyRentalPrice;
        private Krypton.Toolkit.KryptonLabel kryptonLabel13;
        private Krypton.Toolkit.KryptonComboBox cmbEquipmentType;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonDateTimePicker dtpPurchaseDate;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonTextBox txtInvoiceNumber;
        private Krypton.Toolkit.KryptonButton btnDelete;
        private Krypton.Toolkit.KryptonButton btnAdd;
        private Krypton.Toolkit.KryptonButton btnSearch;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox txtSearch;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txtName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox txtInventoryNumber;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonTextBox txtIdentificationNumber;
        private Krypton.Toolkit.KryptonCheckBox chkIsServiced;
        private Krypton.Toolkit.KryptonCheckBox chkIsInTransit;
        private Krypton.Toolkit.KryptonCheckBox chkDisposalDate;
        private Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private Krypton.Toolkit.KryptonDateTimePicker dtpDisposalDate;
        private Krypton.Toolkit.KryptonCheckBox chkStatus;
    }
}