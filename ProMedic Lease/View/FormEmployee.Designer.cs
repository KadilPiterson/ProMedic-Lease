namespace Administracja.Forms
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonEdit = new Button();
            buttonBackInfo = new Button();
            groupBox3 = new GroupBox();
            comboBoxSex = new ComboBox();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            label8 = new Label();
            textBoxMailingAddress = new TextBox();
            groupBox4 = new GroupBox();
            listBoxSpecialites = new ListBox();
            labelSpecialties = new Label();
            comboBoxRole = new ComboBox();
            dateTimePickerBirth = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBoxPESEL = new TextBox();
            label2 = new Label();
            textBoxLastName = new TextBox();
            label1 = new Label();
            textBoxName = new TextBox();
            groupBox1 = new GroupBox();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(441, 388);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(219, 45);
            buttonEdit.TabIndex = 16;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonBackInfo
            // 
            buttonBackInfo.Location = new Point(117, 388);
            buttonBackInfo.Name = "buttonBackInfo";
            buttonBackInfo.Size = new Size(219, 45);
            buttonBackInfo.TabIndex = 2;
            buttonBackInfo.Text = "Back";
            buttonBackInfo.UseVisualStyleBackColor = true;
            buttonBackInfo.Click += buttonBackInfo_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBoxSex);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBoxPhone);
            groupBox3.Controls.Add(textBoxEmail);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(textBoxMailingAddress);
            groupBox3.Location = new Point(80, 249);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(624, 125);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Not required";
            // 
            // comboBoxSex
            // 
            comboBoxSex.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSex.Enabled = false;
            comboBoxSex.FormattingEnabled = true;
            comboBoxSex.Location = new Point(361, 96);
            comboBoxSex.Name = "comboBoxSex";
            comboBoxSex.Size = new Size(219, 23);
            comboBoxSex.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(361, 78);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 14;
            label9.Text = "Sex:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 78);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 12;
            label7.Text = "E-mail:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(361, 34);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 11;
            label6.Text = "Phone:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(361, 52);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.ReadOnly = true;
            textBoxPhone.Size = new Size(219, 23);
            textBoxPhone.TabIndex = 10;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(38, 96);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.ReadOnly = true;
            textBoxEmail.Size = new Size(219, 23);
            textBoxEmail.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 34);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 7;
            label8.Text = "Mailing address:";
            // 
            // textBoxMailingAddress
            // 
            textBoxMailingAddress.Location = new Point(38, 52);
            textBoxMailingAddress.Name = "textBoxMailingAddress";
            textBoxMailingAddress.ReadOnly = true;
            textBoxMailingAddress.Size = new Size(219, 23);
            textBoxMailingAddress.TabIndex = 6;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(listBoxSpecialites);
            groupBox4.Controls.Add(labelSpecialties);
            groupBox4.Controls.Add(comboBoxRole);
            groupBox4.Controls.Add(dateTimePickerBirth);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(textBoxPESEL);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(textBoxLastName);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(textBoxName);
            groupBox4.Location = new Point(80, 19);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(624, 234);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Required";
            // 
            // listBoxSpecialites
            // 
            listBoxSpecialites.FormattingEnabled = true;
            listBoxSpecialites.ItemHeight = 15;
            listBoxSpecialites.Location = new Point(361, 136);
            listBoxSpecialites.Name = "listBoxSpecialites";
            listBoxSpecialites.Size = new Size(219, 79);
            listBoxSpecialites.TabIndex = 13;
            // 
            // labelSpecialties
            // 
            labelSpecialties.AutoSize = true;
            labelSpecialties.Location = new Point(360, 118);
            labelSpecialties.Name = "labelSpecialties";
            labelSpecialties.Size = new Size(65, 15);
            labelSpecialties.TabIndex = 12;
            labelSpecialties.Text = "Specialties:";
            labelSpecialties.Visible = false;
            // 
            // comboBoxRole
            // 
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.Enabled = false;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(361, 92);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(219, 23);
            comboBoxRole.TabIndex = 11;
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Location = new Point(361, 48);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(219, 23);
            dateTimePickerBirth.TabIndex = 10;
            dateTimePickerBirth.ValueChanged += dateTimePickerBirth_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(361, 74);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 9;
            label5.Text = "Role:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(361, 30);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 7;
            label4.Text = "Date of birth:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 118);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 5;
            label3.Text = "PESEL:";
            // 
            // textBoxPESEL
            // 
            textBoxPESEL.Location = new Point(38, 136);
            textBoxPESEL.Name = "textBoxPESEL";
            textBoxPESEL.ReadOnly = true;
            textBoxPESEL.Size = new Size(219, 23);
            textBoxPESEL.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 74);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "Last name:";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(38, 92);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.ReadOnly = true;
            textBoxLastName.Size = new Size(219, 23);
            textBoxLastName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 30);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(38, 48);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(219, 23);
            textBoxName.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonEdit);
            groupBox1.Controls.Add(buttonBackInfo);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Location = new Point(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 446);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information about the employee";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // FormEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEmployee";
            Text = "`";
            Load += FormEmployee_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button buttonEdit;
        private Button buttonBackInfo;
        private GroupBox groupBox3;
        private ComboBox comboBoxSex;
        private Label label9;
        private Label label7;
        private Label label6;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private Label label8;
        private TextBox textBoxMailingAddress;
        private GroupBox groupBox4;
        private Label labelSpecialties;
        private ComboBox comboBoxRole;
        private DateTimePicker dateTimePickerBirth;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBoxPESEL;
        private Label label2;
        private TextBox textBoxLastName;
        private Label label1;
        private TextBox textBoxName;
        private GroupBox groupBox1;
        private ListBox listBoxSpecialites;
    }
}