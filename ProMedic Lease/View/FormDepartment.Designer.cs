﻿namespace ProMedic_Lease.View
{
    partial class FormDepartment
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
            dgvDepartment = new Krypton.Toolkit.KryptonDataGridView();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            txtName = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1053, 413);
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
            btnUpdate.TabIndex = 80;
            btnUpdate.Values.Text = "Zmień";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1053, 29);
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
            btnDelete.TabIndex = 79;
            btnDelete.Values.Text = "Usuń";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(890, 29);
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
            btnAdd.TabIndex = 78;
            btnAdd.Values.Text = "Dodaj";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(178, 29);
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
            btnSearch.TabIndex = 77;
            btnSearch.Values.Text = "Wyszukaj";
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(19, 30);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(153, 26);
            txtSearch.StateCommon.Back.Color1 = Color.White;
            txtSearch.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSearch.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtSearch.StateCommon.Border.Rounding = 12.5F;
            txtSearch.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtSearch.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtSearch.TabIndex = 76;
            // 
            // dgvDepartment
            // 
            dgvDepartment.AllowUserToOrderColumns = true;
            dgvDepartment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepartment.BorderStyle = BorderStyle.None;
            dgvDepartment.ColumnHeadersHeight = 36;
            dgvDepartment.Location = new Point(36, 56);
            dgvDepartment.Margin = new Padding(3, 2, 3, 2);
            dgvDepartment.Name = "dgvDepartment";
            dgvDepartment.ReadOnly = true;
            dgvDepartment.RowHeadersWidth = 51;
            dgvDepartment.Size = new Size(1193, 352);
            dgvDepartment.StateCommon.Background.Color1 = Color.FromArgb(41, 57, 76);
            dgvDepartment.StateCommon.Background.Color2 = Color.FromArgb(41, 57, 76);
            dgvDepartment.StateCommon.Background.ColorAngle = 45F;
            dgvDepartment.StateCommon.Background.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            dgvDepartment.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvDepartment.StateCommon.DataCell.Back.Color1 = Color.FromArgb(41, 57, 76);
            dgvDepartment.StateCommon.DataCell.Back.Color2 = Color.FromArgb(41, 57, 76);
            dgvDepartment.StateCommon.DataCell.Border.Color1 = Color.FromArgb(0, 189, 241);
            dgvDepartment.StateCommon.DataCell.Border.Color2 = Color.FromArgb(0, 189, 241);
            dgvDepartment.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dgvDepartment.StateCommon.DataCell.Content.Color1 = Color.White;
            dgvDepartment.StateCommon.DataCell.Content.Color2 = Color.White;
            dgvDepartment.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(23, 35, 49);
            dgvDepartment.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(23, 35, 49);
            dgvDepartment.StateCommon.HeaderColumn.Border.Color1 = Color.FromArgb(0, 189, 241);
            dgvDepartment.StateCommon.HeaderColumn.Border.Color2 = Color.FromArgb(0, 189, 241);
            dgvDepartment.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dgvDepartment.StateCommon.HeaderColumn.Content.Color1 = Color.White;
            dgvDepartment.StateCommon.HeaderColumn.Content.Color2 = Color.White;
            dgvDepartment.StateCommon.HeaderColumn.Content.ColorAngle = 45F;
            dgvDepartment.StateCommon.HeaderColumn.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dgvDepartment.StateCommon.HeaderRow.Back.Color1 = Color.FromArgb(41, 57, 76);
            dgvDepartment.StateCommon.HeaderRow.Back.Color2 = Color.FromArgb(41, 57, 76);
            dgvDepartment.StateCommon.HeaderRow.Border.Color1 = Color.FromArgb(0, 189, 241);
            dgvDepartment.StateCommon.HeaderRow.Border.Color2 = Color.FromArgb(0, 189, 241);
            dgvDepartment.StateCommon.HeaderRow.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dgvDepartment.StateCommon.HeaderRow.Content.Color1 = Color.White;
            dgvDepartment.StateCommon.HeaderRow.Content.Color2 = Color.White;
            dgvDepartment.TabIndex = 75;
            dgvDepartment.SelectionChanged += dgvDepartment_SelectionChanged;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(19, 11);
            kryptonLabel1.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(69, 18);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel1.TabIndex = 81;
            kryptonLabel1.Values.Text = "Wyszukaj:";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(19, 422);
            kryptonLabel2.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(53, 18);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kryptonLabel2.TabIndex = 83;
            kryptonLabel2.Values.Text = "Nazwa:";
            // 
            // txtName
            // 
            txtName.Location = new Point(19, 441);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(153, 26);
            txtName.StateCommon.Back.Color1 = Color.White;
            txtName.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtName.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtName.StateCommon.Border.Rounding = 12.5F;
            txtName.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtName.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtName.TabIndex = 82;
            // 
            // FormDepartment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 57, 76);
            ClientSize = new Size(1230, 557);
            Controls.Add(kryptonLabel2);
            Controls.Add(txtName);
            Controls.Add(kryptonLabel1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvDepartment);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDepartment";
            Text = "FormDepartment";
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnUpdate;
        private Krypton.Toolkit.KryptonButton btnDelete;
        private Krypton.Toolkit.KryptonButton btnAdd;
        private Krypton.Toolkit.KryptonButton btnSearch;
        private Krypton.Toolkit.KryptonTextBox txtSearch;
        private Krypton.Toolkit.KryptonDataGridView dgvDepartment;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txtName;
    }
}