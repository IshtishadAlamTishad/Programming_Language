namespace Curd_Operation
{
    partial class Form1
    {       
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region 
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtStudentName = new TextBox();
            InsertButton = new Button();
            StudentDataGridView = new DataGridView();
            UpdateButton = new Button();
            DeleteButton = new Button();
            ResetButton = new Button();
            ExitButton = new Button();
            txtMotherName = new TextBox();
            txtFatherName = new TextBox();
            txtMobileNumber = new TextBox();
            txtAddress = new TextBox();
            txtReligion = new TextBox();
            txtNationality = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            BirthDatePicker = new DateTimePicker();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)StudentDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(93, 33);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // txtStudentName
            // 
            txtStudentName.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtStudentName.Location = new Point(189, 27);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(367, 34);
            txtStudentName.TabIndex = 1;
            txtStudentName.TextChanged += textBox1_TextChanged;
            // 
            // InsertButton
            // 
            InsertButton.BackColor = SystemColors.ControlDark;
            InsertButton.BackgroundImage = (Image)resources.GetObject("InsertButton.BackgroundImage");
            InsertButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            InsertButton.ForeColor = SystemColors.ButtonHighlight;
            InsertButton.Location = new Point(27, 401);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new Size(118, 56);
            InsertButton.TabIndex = 2;
            InsertButton.Text = "INSERT";
            InsertButton.UseVisualStyleBackColor = false;
            InsertButton.Click += button1_Click;
            // 
            // StudentDataGridView
            // 
            StudentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentDataGridView.Location = new Point(27, 477);
            StudentDataGridView.Name = "StudentDataGridView";
            StudentDataGridView.ReadOnly = true;
            StudentDataGridView.RowHeadersWidth = 51;
            StudentDataGridView.RowTemplate.Height = 29;
            StudentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StudentDataGridView.Size = new Size(1013, 284);
            StudentDataGridView.TabIndex = 4;
            StudentDataGridView.CellClick += StudentDataGridView_CellContentClick;
            StudentDataGridView.CellContentClick += StudentDataGridView_CellContentClick;
            // 
            // UpdateButton
            // 
            UpdateButton.BackgroundImage = (Image)resources.GetObject("UpdateButton.BackgroundImage");
            UpdateButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateButton.ForeColor = SystemColors.ButtonFace;
            UpdateButton.Location = new Point(164, 402);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(118, 56);
            UpdateButton.TabIndex = 5;
            UpdateButton.Text = "UPDATE";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += button2_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackgroundImage = (Image)resources.GetObject("DeleteButton.BackgroundImage");
            DeleteButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteButton.ForeColor = SystemColors.ControlLightLight;
            DeleteButton.Location = new Point(301, 401);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(118, 56);
            DeleteButton.TabIndex = 6;
            DeleteButton.Text = "DELETE";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += button3_Click;
            // 
            // ResetButton
            // 
            ResetButton.BackgroundImage = (Image)resources.GetObject("ResetButton.BackgroundImage");
            ResetButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ResetButton.Location = new Point(439, 401);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(118, 56);
            ResetButton.TabIndex = 7;
            ResetButton.Text = "RESET";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += button4_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackgroundImage = (Image)resources.GetObject("ExitButton.BackgroundImage");
            ExitButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ExitButton.ForeColor = SystemColors.ButtonHighlight;
            ExitButton.Location = new Point(922, 402);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(118, 56);
            ExitButton.TabIndex = 8;
            ExitButton.Text = "EXIT";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += button5_Click;
            // 
            // txtMotherName
            // 
            txtMotherName.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtMotherName.Location = new Point(189, 88);
            txtMotherName.Name = "txtMotherName";
            txtMotherName.Size = new Size(367, 34);
            txtMotherName.TabIndex = 9;
            txtMotherName.TextChanged += textBox2_TextChanged;
            // 
            // txtFatherName
            // 
            txtFatherName.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtFatherName.Location = new Point(189, 148);
            txtFatherName.Name = "txtFatherName";
            txtFatherName.Size = new Size(367, 34);
            txtFatherName.TabIndex = 10;
            txtFatherName.TextChanged += textBox3_TextChanged;
            // 
            // txtMobileNumber
            // 
            txtMobileNumber.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtMobileNumber.Location = new Point(735, 24);
            txtMobileNumber.Name = "txtMobileNumber";
            txtMobileNumber.Size = new Size(305, 34);
            txtMobileNumber.TabIndex = 12;
            txtMobileNumber.TextChanged += txtMobileNumber_TextChanged;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(735, 88);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(305, 34);
            txtAddress.TabIndex = 13;
            // 
            // txtReligion
            // 
            txtReligion.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtReligion.Location = new Point(735, 154);
            txtReligion.Name = "txtReligion";
            txtReligion.Size = new Size(305, 34);
            txtReligion.TabIndex = 14;
            // 
            // txtNationality
            // 
            txtNationality.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNationality.Location = new Point(735, 218);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(305, 34);
            txtNationality.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(10, 91);
            label2.Name = "label2";
            label2.Size = new Size(168, 25);
            label2.TabIndex = 16;
            label2.Text = "Mother Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(18, 152);
            label3.Name = "label3";
            label3.Size = new Size(160, 25);
            label3.TabIndex = 17;
            label3.Text = "Father Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(20, 227);
            label4.Name = "label4";
            label4.Size = new Size(158, 25);
            label4.TabIndex = 18;
            label4.Text = "Date of Birth :";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(605, 30);
            label5.Name = "label5";
            label5.Size = new Size(124, 25);
            label5.TabIndex = 19;
            label5.Text = "Mobile No:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(628, 91);
            label6.Name = "label6";
            label6.Size = new Size(101, 25);
            label6.TabIndex = 20;
            label6.Text = "Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(628, 157);
            label7.Name = "label7";
            label7.Size = new Size(100, 25);
            label7.TabIndex = 21;
            label7.Text = "Religion:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(595, 218);
            label8.Name = "label8";
            label8.Size = new Size(134, 25);
            label8.TabIndex = 22;
            label8.Text = "Nationality :";
            // 
            // BirthDatePicker
            // 
            BirthDatePicker.CustomFormat = "dd-MM-yyyy";
            BirthDatePicker.Format = DateTimePickerFormat.Custom;
            BirthDatePicker.Location = new Point(190, 227);
            BirthDatePicker.Margin = new Padding(3, 4, 3, 4);
            BirthDatePicker.Name = "BirthDatePicker";
            BirthDatePicker.Size = new Size(175, 27);
            BirthDatePicker.TabIndex = 23;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.ForeColor = SystemColors.ButtonHighlight;
            radioButton1.Location = new Point(737, 293);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 24;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.ForeColor = SystemColors.ButtonHighlight;
            radioButton2.Location = new Point(737, 325);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 25;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.Transparent;
            radioButton3.ForeColor = SystemColors.ButtonHighlight;
            radioButton3.Location = new Point(826, 295);
            radioButton3.Margin = new Padding(3, 4, 3, 4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(67, 24);
            radioButton3.TabIndex = 26;
            radioButton3.TabStop = true;
            radioButton3.Text = "Other";
            radioButton3.UseVisualStyleBackColor = false;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(626, 295);
            label9.Name = "label9";
            label9.Size = new Size(102, 25);
            label9.TabIndex = 27;
            label9.Text = "Gender :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1062, 800);
            Controls.Add(label9);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(BirthDatePicker);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNationality);
            Controls.Add(txtReligion);
            Controls.Add(txtAddress);
            Controls.Add(txtMobileNumber);
            Controls.Add(txtFatherName);
            Controls.Add(txtMotherName);
            Controls.Add(ExitButton);
            Controls.Add(ResetButton);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(StudentDataGridView);
            Controls.Add(InsertButton);
            Controls.Add(txtStudentName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Students Information";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)StudentDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtStudentName;
        private Button InsertButton;
        private DataGridView StudentDataGridView;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button ResetButton;
        private Button ExitButton;
        private TextBox txtMotherName;
        private TextBox txtFatherName;
        private TextBox txtMobileNumber;
        private TextBox txtAddress;
        private TextBox txtReligion;
        private TextBox txtNationality;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker BirthDatePicker;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label9;
    }
}