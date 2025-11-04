namespace OOP_Project
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            dateTimePicker1 = new DateTimePicker();
            bindingSource1 = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            nameTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            ageTextBox = new TextBox();
            label6 = new Label();
            phoneNumberTextBox = new TextBox();
            label7 = new Label();
            emailTextBox = new TextBox();
            label8 = new Label();
            submitButton = new Button();
            label9 = new Label();
            label10 = new Label();
            dateTextBox = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label1 = new Label();
            streetTextBox = new TextBox();
            label17 = new Label();
            cityTextBox = new TextBox();
            label18 = new Label();
            stateProvinceTextBox = new TextBox();
            label19 = new Label();
            postalZipTextBox = new TextBox();
            label21 = new Label();
            label20 = new Label();
            yesCheckBox = new CheckBox();
            noCheckBox = new CheckBox();
            genderComboBox = new ComboBox();
            dateOfBirthTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(260, 17);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(208, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 38);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 184);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 5;
            label3.Text = "NAME";
            label3.Click += label3_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Location = new Point(12, 202);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(339, 23);
            nameTextBox.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(372, 184);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 7;
            label4.Text = "GENDER";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(446, 184);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 10;
            label5.Text = "AGE";
            // 
            // ageTextBox
            // 
            ageTextBox.BorderStyle = BorderStyle.FixedSingle;
            ageTextBox.Location = new Point(446, 202);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(51, 23);
            ageTextBox.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 83);
            label6.Name = "label6";
            label6.Size = new Size(137, 15);
            label6.TabIndex = 12;
            label6.Text = "Pls fill in the form below.";
            label6.Click += label6_Click;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
            phoneNumberTextBox.Location = new Point(12, 332);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(137, 23);
            phoneNumberTextBox.TabIndex = 4;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(177, 314);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 14;
            label7.Text = "E-mail";
            // 
            // emailTextBox
            // 
            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.Location = new Point(176, 332);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(201, 23);
            emailTextBox.TabIndex = 5;
            emailTextBox.TextChanged += textBox4_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 314);
            label8.Name = "label8";
            label8.Size = new Size(91, 15);
            label8.TabIndex = 16;
            label8.Text = "Phone Number";
            label8.Click += label8_Click;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(324, 562);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(144, 43);
            submitButton.TabIndex = 12;
            submitButton.Text = "SUBMIT";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 367);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 17;
            label9.Text = "Address";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(11, 117);
            label10.Name = "label10";
            label10.Size = new Size(159, 15);
            label10.TabIndex = 18;
            label10.Text = "Registration Date and Time";
            // 
            // dateTextBox
            // 
            dateTextBox.BorderStyle = BorderStyle.FixedSingle;
            dateTextBox.Enabled = false;
            dateTextBox.Location = new Point(12, 135);
            dateTextBox.Name = "dateTextBox";
            dateTextBox.Size = new Size(159, 23);
            dateTextBox.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(12, 238);
            label12.Name = "label12";
            label12.Size = new Size(80, 15);
            label12.TabIndex = 23;
            label12.Text = "Date of Birth";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(12, 253);
            label13.Name = "label13";
            label13.Size = new Size(71, 13);
            label13.TabIndex = 24;
            label13.Text = "YYYY/MM/DD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(182, 64);
            label1.TabIndex = 30;
            label1.Text = "WELCOME TO \r\nPRMS";
            // 
            // streetTextBox
            // 
            streetTextBox.BorderStyle = BorderStyle.FixedSingle;
            streetTextBox.Location = new Point(11, 401);
            streetTextBox.Name = "streetTextBox";
            streetTextBox.Size = new Size(365, 23);
            streetTextBox.TabIndex = 6;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(11, 385);
            label17.Name = "label17";
            label17.Size = new Size(74, 13);
            label17.TabIndex = 33;
            label17.Text = "Street Address";
            // 
            // cityTextBox
            // 
            cityTextBox.BorderStyle = BorderStyle.FixedSingle;
            cityTextBox.Location = new Point(11, 443);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(168, 23);
            cityTextBox.TabIndex = 7;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(11, 427);
            label18.Name = "label18";
            label18.Size = new Size(24, 13);
            label18.TabIndex = 35;
            label18.Text = "City";
            label18.Click += label18_Click;
            // 
            // stateProvinceTextBox
            // 
            stateProvinceTextBox.BorderStyle = BorderStyle.FixedSingle;
            stateProvinceTextBox.Location = new Point(196, 443);
            stateProvinceTextBox.Name = "stateProvinceTextBox";
            stateProvinceTextBox.Size = new Size(180, 23);
            stateProvinceTextBox.TabIndex = 8;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(196, 427);
            label19.Name = "label19";
            label19.Size = new Size(79, 13);
            label19.TabIndex = 37;
            label19.Text = "State / Province";
            label19.Click += label19_Click;
            // 
            // postalZipTextBox
            // 
            postalZipTextBox.BorderStyle = BorderStyle.FixedSingle;
            postalZipTextBox.Location = new Point(12, 485);
            postalZipTextBox.Name = "postalZipTextBox";
            postalZipTextBox.Size = new Size(137, 23);
            postalZipTextBox.TabIndex = 9;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(12, 469);
            label21.Name = "label21";
            label21.Size = new Size(81, 13);
            label21.TabIndex = 40;
            label21.Text = "Postal / zip code";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(7, 525);
            label20.Name = "label20";
            label20.Size = new Size(194, 15);
            label20.TabIndex = 41;
            label20.Text = "Taking any medications currently?";
            // 
            // yesCheckBox
            // 
            yesCheckBox.AutoSize = true;
            yesCheckBox.Location = new Point(12, 543);
            yesCheckBox.Name = "yesCheckBox";
            yesCheckBox.Size = new Size(43, 19);
            yesCheckBox.TabIndex = 10;
            yesCheckBox.Text = "Yes";
            yesCheckBox.UseVisualStyleBackColor = true;
            // 
            // noCheckBox
            // 
            noCheckBox.AutoSize = true;
            noCheckBox.Location = new Point(61, 543);
            noCheckBox.Name = "noCheckBox";
            noCheckBox.Size = new Size(42, 19);
            noCheckBox.TabIndex = 11;
            noCheckBox.Text = "No";
            noCheckBox.UseVisualStyleBackColor = true;
            noCheckBox.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(357, 202);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(83, 23);
            genderComboBox.TabIndex = 1;
            // 
            // dateOfBirthTextBox
            // 
            dateOfBirthTextBox.Location = new Point(12, 269);
            dateOfBirthTextBox.Name = "dateOfBirthTextBox";
            dateOfBirthTextBox.Size = new Size(100, 23);
            dateOfBirthTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 626);
            Controls.Add(dateOfBirthTextBox);
            Controls.Add(genderComboBox);
            Controls.Add(noCheckBox);
            Controls.Add(yesCheckBox);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(postalZipTextBox);
            Controls.Add(label19);
            Controls.Add(stateProvinceTextBox);
            Controls.Add(label18);
            Controls.Add(cityTextBox);
            Controls.Add(label17);
            Controls.Add(streetTextBox);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(dateTextBox);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(submitButton);
            Controls.Add(label8);
            Controls.Add(emailTextBox);
            Controls.Add(label7);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(label6);
            Controls.Add(ageTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(nameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient Records Management System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private BindingSource bindingSource1;
        private Label label2;
        private Label label3;
        private TextBox nameTextBox;
        private Label label4;
        private Label label5;
        private TextBox ageTextBox;
        private Label label6;
        private TextBox phoneNumberTextBox;
        private Label label7;
        private TextBox emailTextBox;
        private Label label8;
        private Button submitButton;
        private Label label9;
        private Label label10;
        private TextBox dateTextBox;
        private Label label12;
        private Label label13;
        private Label label1;
        private TextBox streetTextBox;
        private Label label17;
        private TextBox cityTextBox;
        private Label label18;
        private TextBox stateProvinceTextBox;
        private Label label19;
        private TextBox postalZipTextBox;
        private Label label21;
        private Label label20;
        private CheckBox yesCheckBox;
        private CheckBox noCheckBox;
        private ComboBox genderComboBox;
        private TextBox dateOfBirthTextBox;
    }
}
