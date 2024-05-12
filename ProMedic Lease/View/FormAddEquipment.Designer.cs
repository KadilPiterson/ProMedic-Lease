namespace ProMedic_Lease.View
{
    partial class FormAddEquipment
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
            chkIsInTransit = new Krypton.Toolkit.KryptonCheckBox();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            txtIdentificationNumber = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            txtName = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel15 = new Krypton.Toolkit.KryptonLabel();
            nudDailyRentalPrice = new Krypton.Toolkit.KryptonNumericUpDown();
            kryptonLabel13 = new Krypton.Toolkit.KryptonLabel();
            cmbEquipmentType = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            dtpPurchaseDate = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            txtInvoiceNumber = new Krypton.Toolkit.KryptonTextBox();
            btnSave = new Krypton.Toolkit.KryptonButton();
            txtInventoryNumberView = new Krypton.Toolkit.KryptonTextBox();
            numInventoryNumber = new Krypton.Toolkit.KryptonNumericUpDown();
            ((System.ComponentModel.ISupportInitialize)cmbEquipmentType).BeginInit();
            SuspendLayout();
            // 
            // chkIsInTransit
            // 
            chkIsInTransit.Location = new Point(171, 270);
            chkIsInTransit.Margin = new Padding(3, 2, 3, 2);
            chkIsInTransit.Name = "chkIsInTransit";
            chkIsInTransit.Size = new Size(89, 23);
            chkIsInTransit.StateCommon.ShortText.Color1 = Color.White;
            chkIsInTransit.StateCommon.ShortText.Color2 = Color.White;
            chkIsInTransit.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            chkIsInTransit.TabIndex = 81;
            chkIsInTransit.Values.Text = "Dostawa";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(31, 136);
            kryptonLabel4.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(72, 18);
            kryptonLabel4.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel4.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel4.TabIndex = 79;
            kryptonLabel4.Values.Text = "Nr seryjny:";
            // 
            // txtIdentificationNumber
            // 
            txtIdentificationNumber.Location = new Point(170, 128);
            txtIdentificationNumber.Margin = new Padding(3, 2, 3, 2);
            txtIdentificationNumber.Name = "txtIdentificationNumber";
            txtIdentificationNumber.Size = new Size(246, 26);
            txtIdentificationNumber.StateCommon.Back.Color1 = Color.White;
            txtIdentificationNumber.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtIdentificationNumber.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtIdentificationNumber.StateCommon.Border.Rounding = 12.5F;
            txtIdentificationNumber.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtIdentificationNumber.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtIdentificationNumber.TabIndex = 78;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(34, 200);
            kryptonLabel3.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(109, 18);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel3.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel3.TabIndex = 77;
            kryptonLabel3.Values.Text = "Nr inwentarzowy:";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(35, 43);
            kryptonLabel2.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(53, 18);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel2.TabIndex = 75;
            kryptonLabel2.Values.Text = "Nazwa:";
            // 
            // txtName
            // 
            txtName.Location = new Point(171, 35);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(246, 26);
            txtName.StateCommon.Back.Color1 = Color.White;
            txtName.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtName.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtName.StateCommon.Border.Rounding = 12.5F;
            txtName.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtName.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtName.TabIndex = 74;
            // 
            // kryptonLabel15
            // 
            kryptonLabel15.Location = new Point(32, 234);
            kryptonLabel15.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel15.Name = "kryptonLabel15";
            kryptonLabel15.Size = new Size(130, 18);
            kryptonLabel15.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel15.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel15.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel15.TabIndex = 73;
            kryptonLabel15.Values.Text = "Koszt wypożyczenia:";
            // 
            // nudDailyRentalPrice
            // 
            nudDailyRentalPrice.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            nudDailyRentalPrice.Location = new Point(171, 222);
            nudDailyRentalPrice.Margin = new Padding(3, 2, 3, 2);
            nudDailyRentalPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudDailyRentalPrice.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            nudDailyRentalPrice.Name = "nudDailyRentalPrice";
            nudDailyRentalPrice.Size = new Size(246, 30);
            nudDailyRentalPrice.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            nudDailyRentalPrice.StateCommon.Border.Rounding = 12.5F;
            nudDailyRentalPrice.StateCommon.Border.Width = 1;
            nudDailyRentalPrice.TabIndex = 72;
            nudDailyRentalPrice.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // kryptonLabel13
            // 
            kryptonLabel13.Location = new Point(31, 106);
            kryptonLabel13.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel13.Name = "kryptonLabel13";
            kryptonLabel13.Size = new Size(81, 18);
            kryptonLabel13.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel13.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel13.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel13.TabIndex = 71;
            kryptonLabel13.Values.Text = "Typ sprzętu:";
            // 
            // cmbEquipmentType
            // 
            cmbEquipmentType.DropDownWidth = 151;
            cmbEquipmentType.IntegralHeight = false;
            cmbEquipmentType.Location = new Point(170, 95);
            cmbEquipmentType.Margin = new Padding(3, 2, 3, 2);
            cmbEquipmentType.Name = "cmbEquipmentType";
            cmbEquipmentType.Size = new Size(246, 29);
            cmbEquipmentType.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbEquipmentType.StateCommon.ComboBox.Border.Rounding = 12.5F;
            cmbEquipmentType.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbEquipmentType.StateCommon.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cmbEquipmentType.TabIndex = 70;
            cmbEquipmentType.SelectedIndexChanged += cmbEquipmentType_SelectedIndexChanged;
            // 
            // kryptonLabel11
            // 
            kryptonLabel11.Location = new Point(31, 166);
            kryptonLabel11.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel11.Name = "kryptonLabel11";
            kryptonLabel11.Size = new Size(86, 18);
            kryptonLabel11.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel11.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel11.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel11.TabIndex = 69;
            kryptonLabel11.Values.Text = "Data zakupu:";
            // 
            // dtpPurchaseDate
            // 
            dtpPurchaseDate.Location = new Point(170, 158);
            dtpPurchaseDate.Margin = new Padding(3, 2, 3, 2);
            dtpPurchaseDate.Name = "dtpPurchaseDate";
            dtpPurchaseDate.Size = new Size(246, 26);
            dtpPurchaseDate.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpPurchaseDate.StateCommon.Border.Rounding = 12.5F;
            dtpPurchaseDate.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dtpPurchaseDate.TabIndex = 68;
            dtpPurchaseDate.ValueNullable = new DateTime(2024, 1, 1, 19, 52, 0, 0);
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(31, 73);
            kryptonLabel5.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(70, 18);
            kryptonLabel5.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel5.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel5.TabIndex = 67;
            kryptonLabel5.Values.Text = "Nr faktury:";
            // 
            // txtInvoiceNumber
            // 
            txtInvoiceNumber.Location = new Point(170, 65);
            txtInvoiceNumber.Margin = new Padding(3, 2, 3, 2);
            txtInvoiceNumber.Name = "txtInvoiceNumber";
            txtInvoiceNumber.Size = new Size(246, 26);
            txtInvoiceNumber.StateCommon.Back.Color1 = Color.White;
            txtInvoiceNumber.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtInvoiceNumber.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtInvoiceNumber.StateCommon.Border.Rounding = 12.5F;
            txtInvoiceNumber.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtInvoiceNumber.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtInvoiceNumber.TabIndex = 66;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(150, 450);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.OverrideDefault.Back.Color1 = Color.FromArgb(23, 35, 49);
            btnSave.OverrideDefault.Back.Color2 = Color.FromArgb(23, 35, 49);
            btnSave.OverrideDefault.Back.ColorAngle = 45F;
            btnSave.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSave.OverrideDefault.Border.Color1 = Color.FromArgb(23, 35, 49);
            btnSave.OverrideDefault.Border.Color2 = Color.FromArgb(23, 35, 49);
            btnSave.OverrideDefault.Border.ColorAngle = 45F;
            btnSave.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSave.OverrideDefault.Border.Rounding = 12.5F;
            btnSave.OverrideDefault.Border.Width = 1;
            btnSave.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnSave.Size = new Size(158, 23);
            btnSave.StateCommon.Back.Color1 = Color.FromArgb(23, 35, 49);
            btnSave.StateCommon.Back.Color2 = Color.FromArgb(23, 35, 49);
            btnSave.StateCommon.Back.ColorAngle = 45F;
            btnSave.StateCommon.Border.Color1 = Color.FromArgb(23, 35, 49);
            btnSave.StateCommon.Border.Color2 = Color.FromArgb(23, 35, 49);
            btnSave.StateCommon.Border.ColorAngle = 45F;
            btnSave.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSave.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSave.StateCommon.Border.Rounding = 12.5F;
            btnSave.StateCommon.Border.Width = 1;
            btnSave.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSave.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSave.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnSave.StatePressed.Back.Color1 = Color.FromArgb(0, 189, 241);
            btnSave.StatePressed.Back.Color2 = Color.FromArgb(0, 189, 241);
            btnSave.StatePressed.Back.ColorAngle = 130F;
            btnSave.StatePressed.Border.Color1 = Color.FromArgb(0, 189, 241);
            btnSave.StatePressed.Border.Color2 = Color.FromArgb(0, 189, 241);
            btnSave.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSave.StatePressed.Border.Rounding = 12.5F;
            btnSave.StatePressed.Border.Width = 1;
            btnSave.StateTracking.Back.Color1 = Color.FromArgb(0, 189, 241);
            btnSave.StateTracking.Back.ColorAngle = 45F;
            btnSave.StateTracking.Border.Color1 = Color.FromArgb(0, 189, 241);
            btnSave.StateTracking.Border.Color2 = Color.FromArgb(0, 189, 241);
            btnSave.StateTracking.Border.ColorAngle = 45F;
            btnSave.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSave.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSave.StateTracking.Border.Rounding = 12.5F;
            btnSave.StateTracking.Border.Width = 1;
            btnSave.TabIndex = 86;
            btnSave.Values.Text = "Zapisz";
            btnSave.Click += btnSave_Click;
            // 
            // txtInventoryNumberView
            // 
            txtInventoryNumberView.Enabled = false;
            txtInventoryNumberView.Location = new Point(241, 192);
            txtInventoryNumberView.Margin = new Padding(3, 2, 3, 2);
            txtInventoryNumberView.Name = "txtInventoryNumberView";
            txtInventoryNumberView.Size = new Size(177, 26);
            txtInventoryNumberView.StateCommon.Back.Color1 = Color.White;
            txtInventoryNumberView.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtInventoryNumberView.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtInventoryNumberView.StateCommon.Border.Rounding = 12.5F;
            txtInventoryNumberView.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtInventoryNumberView.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtInventoryNumberView.TabIndex = 87;
            // 
            // numInventoryNumber
            // 
            numInventoryNumber.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            numInventoryNumber.Location = new Point(173, 188);
            numInventoryNumber.Margin = new Padding(3, 2, 3, 2);
            numInventoryNumber.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numInventoryNumber.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            numInventoryNumber.Name = "numInventoryNumber";
            numInventoryNumber.Size = new Size(64, 30);
            numInventoryNumber.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            numInventoryNumber.StateCommon.Border.Rounding = 12.5F;
            numInventoryNumber.StateCommon.Border.Width = 1;
            numInventoryNumber.TabIndex = 88;
            numInventoryNumber.Value = new decimal(new int[] { 0, 0, 0, 0 });
            numInventoryNumber.ValueChanged += numInventoryNumber_ValueChanged;
            // 
            // FormAddEquipment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 57, 76);
            ClientSize = new Size(461, 497);
            Controls.Add(numInventoryNumber);
            Controls.Add(txtInventoryNumberView);
            Controls.Add(btnSave);
            Controls.Add(chkIsInTransit);
            Controls.Add(kryptonLabel4);
            Controls.Add(txtIdentificationNumber);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonLabel2);
            Controls.Add(txtName);
            Controls.Add(kryptonLabel15);
            Controls.Add(nudDailyRentalPrice);
            Controls.Add(kryptonLabel13);
            Controls.Add(cmbEquipmentType);
            Controls.Add(kryptonLabel11);
            Controls.Add(dtpPurchaseDate);
            Controls.Add(kryptonLabel5);
            Controls.Add(txtInvoiceNumber);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAddEquipment";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)cmbEquipmentType).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Krypton.Toolkit.KryptonCheckBox chkIsInTransit;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonTextBox txtIdentificationNumber;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txtName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel15;
        private Krypton.Toolkit.KryptonNumericUpDown nudDailyRentalPrice;
        private Krypton.Toolkit.KryptonLabel kryptonLabel13;
        private Krypton.Toolkit.KryptonComboBox cmbEquipmentType;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonDateTimePicker dtpPurchaseDate;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonTextBox txtInvoiceNumber;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonTextBox txtInventoryNumberView;
        private Krypton.Toolkit.KryptonNumericUpDown numInventoryNumber;
    }
}