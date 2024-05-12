namespace ProMedic_Lease.View
{
    partial class FormAddRental
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
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            cmbEmployee = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            dtpStartDate = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            cmbClient = new Krypton.Toolkit.KryptonComboBox();
            cobEquipment = new Krypton.Toolkit.KryptonLabel();
            cmbEquipment = new Krypton.Toolkit.KryptonComboBox();
            txtComment = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            btnSave = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)cmbEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbClient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbEquipment).BeginInit();
            SuspendLayout();
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(32, 44);
            kryptonLabel4.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(73, 18);
            kryptonLabel4.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel4.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel4.TabIndex = 84;
            kryptonLabel4.Values.Text = "Pracownik:";
            // 
            // cmbEmployee
            // 
            cmbEmployee.DropDownWidth = 151;
            cmbEmployee.IntegralHeight = false;
            cmbEmployee.Location = new Point(189, 33);
            cmbEmployee.Margin = new Padding(3, 2, 3, 2);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(246, 29);
            cmbEmployee.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbEmployee.StateCommon.ComboBox.Border.Rounding = 12.5F;
            cmbEmployee.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbEmployee.StateCommon.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cmbEmployee.TabIndex = 83;
            // 
            // kryptonLabel11
            // 
            kryptonLabel11.Location = new Point(32, 140);
            kryptonLabel11.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel11.Name = "kryptonLabel11";
            kryptonLabel11.Size = new Size(113, 18);
            kryptonLabel11.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel11.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel11.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel11.TabIndex = 80;
            kryptonLabel11.Values.Text = "Data rozpoczęcia:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(189, 132);
            dtpStartDate.Margin = new Padding(3, 2, 3, 2);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(246, 26);
            dtpStartDate.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpStartDate.StateCommon.Border.Rounding = 12.5F;
            dtpStartDate.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dtpStartDate.TabIndex = 79;
            dtpStartDate.ValueNullable = new DateTime(2024, 1, 1, 19, 52, 0, 0);
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(32, 110);
            kryptonLabel2.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(47, 18);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel2.TabIndex = 78;
            kryptonLabel2.Values.Text = "Klient:";
            // 
            // cmbClient
            // 
            cmbClient.DropDownWidth = 151;
            cmbClient.IntegralHeight = false;
            cmbClient.Location = new Point(189, 99);
            cmbClient.Margin = new Padding(3, 2, 3, 2);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new Size(246, 29);
            cmbClient.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbClient.StateCommon.ComboBox.Border.Rounding = 12.5F;
            cmbClient.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbClient.StateCommon.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cmbClient.TabIndex = 77;
            // 
            // cobEquipment
            // 
            cobEquipment.Location = new Point(32, 77);
            cobEquipment.Margin = new Padding(3, 2, 3, 2);
            cobEquipment.Name = "cobEquipment";
            cobEquipment.Size = new Size(51, 18);
            cobEquipment.StateCommon.ShortText.Color1 = Color.White;
            cobEquipment.StateCommon.ShortText.Color2 = Color.White;
            cobEquipment.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            cobEquipment.TabIndex = 76;
            cobEquipment.Values.Text = "Sprzęt:";
            // 
            // cmbEquipment
            // 
            cmbEquipment.DropDownWidth = 151;
            cmbEquipment.IntegralHeight = false;
            cmbEquipment.Location = new Point(189, 66);
            cmbEquipment.Margin = new Padding(3, 2, 3, 2);
            cmbEquipment.Name = "cmbEquipment";
            cmbEquipment.Size = new Size(246, 29);
            cmbEquipment.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbEquipment.StateCommon.ComboBox.Border.Rounding = 12.5F;
            cmbEquipment.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbEquipment.StateCommon.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cmbEquipment.TabIndex = 75;
            // 
            // txtComment
            // 
            txtComment.Location = new Point(189, 162);
            txtComment.Margin = new Padding(3, 2, 3, 2);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(246, 26);
            txtComment.StateCommon.Back.Color1 = Color.White;
            txtComment.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtComment.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtComment.StateCommon.Border.Rounding = 12.5F;
            txtComment.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtComment.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtComment.TabIndex = 86;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(32, 170);
            kryptonLabel5.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(50, 18);
            kryptonLabel5.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel5.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel5.TabIndex = 87;
            kryptonLabel5.Values.Text = "Uwagi:";
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
            btnSave.TabIndex = 88;
            btnSave.Values.Text = "Zapisz";
            btnSave.Click += btnSave_Click;
            // 
            // FormAddRental
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 57, 76);
            ClientSize = new Size(461, 497);
            Controls.Add(btnSave);
            Controls.Add(kryptonLabel5);
            Controls.Add(txtComment);
            Controls.Add(kryptonLabel4);
            Controls.Add(cmbEmployee);
            Controls.Add(kryptonLabel11);
            Controls.Add(dtpStartDate);
            Controls.Add(kryptonLabel2);
            Controls.Add(cmbClient);
            Controls.Add(cobEquipment);
            Controls.Add(cmbEquipment);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAddRental";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)cmbEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbClient).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbEquipment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonComboBox cmbEmployee;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonDateTimePicker dtpStartDate;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonComboBox cmbClient;
        private Krypton.Toolkit.KryptonLabel cobEquipment;
        private Krypton.Toolkit.KryptonComboBox cmbEquipment;
        private Krypton.Toolkit.KryptonTextBox txtComment;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonButton btnSave;
    }
}