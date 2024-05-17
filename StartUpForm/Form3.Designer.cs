namespace StartUpForm
{
    partial class Form3
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            RadioErrorLabel = new Label();
            ShadeFacultyButton = new RadioButton();
            ShadeStudentButton = new RadioButton();
            shortPasswordErrorLabel = new Label();
            usernameErrorLabel = new Label();
            PasswordsMatchntErrorLabel = new Label();
            lastNameErrorLabel = new Label();
            firstNameErrorLabel = new Label();
            clearButton = new Button();
            checkBox1 = new CheckBox();
            button2 = new Button();
            label8 = new Label();
            emailAddress = new TextBox();
            panel10 = new Panel();
            label7 = new Label();
            lastName = new TextBox();
            panel9 = new Panel();
            label6 = new Label();
            firstName = new TextBox();
            label5 = new Label();
            panel8 = new Panel();
            panel7 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            Password = new TextBox();
            addUserName = new TextBox();
            Password2 = new TextBox();
            emailAddressErrorLabel = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(103, 143, 59);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 494);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.VSU_Gig_Hub_Icon;
            pictureBox1.Location = new Point(6, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(316, 304);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(320, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(479, 450);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(322, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(538, 494);
            panel3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22F, FontStyle.Bold);
            label1.Location = new Point(62, 21);
            label1.Name = "label1";
            label1.Size = new Size(137, 37);
            label1.TabIndex = 11;
            label1.Text = "SIGN-UP";
            // 
            // panel4
            // 
            panel4.Controls.Add(RadioErrorLabel);
            panel4.Controls.Add(ShadeFacultyButton);
            panel4.Controls.Add(ShadeStudentButton);
            panel4.Controls.Add(shortPasswordErrorLabel);
            panel4.Controls.Add(usernameErrorLabel);
            panel4.Controls.Add(PasswordsMatchntErrorLabel);
            panel4.Controls.Add(lastNameErrorLabel);
            panel4.Controls.Add(firstNameErrorLabel);
            panel4.Controls.Add(clearButton);
            panel4.Controls.Add(checkBox1);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(emailAddress);
            panel4.Controls.Add(panel10);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(lastName);
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(firstName);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(Password);
            panel4.Controls.Add(addUserName);
            panel4.Controls.Add(Password2);
            panel4.Controls.Add(emailAddressErrorLabel);
            panel4.Controls.Add(button1);
            panel4.Location = new Point(91, 41);
            panel4.Name = "panel4";
            panel4.Size = new Size(351, 450);
            panel4.TabIndex = 10;
            // 
            // RadioErrorLabel
            // 
            RadioErrorLabel.AutoSize = true;
            RadioErrorLabel.ForeColor = Color.Red;
            RadioErrorLabel.Location = new Point(14, 273);
            RadioErrorLabel.Name = "RadioErrorLabel";
            RadioErrorLabel.Size = new Size(10, 15);
            RadioErrorLabel.TabIndex = 32;
            RadioErrorLabel.Text = " ";
            // 
            // ShadeFacultyButton
            // 
            ShadeFacultyButton.AutoSize = true;
            ShadeFacultyButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShadeFacultyButton.Location = new Point(207, 255);
            ShadeFacultyButton.Name = "ShadeFacultyButton";
            ShadeFacultyButton.Size = new Size(71, 21);
            ShadeFacultyButton.TabIndex = 31;
            ShadeFacultyButton.TabStop = true;
            ShadeFacultyButton.Text = "Faculty";
            ShadeFacultyButton.UseVisualStyleBackColor = true;
            ShadeFacultyButton.CheckedChanged += ShadeFacultyButton_CheckedChanged;
            // 
            // ShadeStudentButton
            // 
            ShadeStudentButton.AutoSize = true;
            ShadeStudentButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShadeStudentButton.Location = new Point(60, 255);
            ShadeStudentButton.Name = "ShadeStudentButton";
            ShadeStudentButton.Size = new Size(75, 21);
            ShadeStudentButton.TabIndex = 30;
            ShadeStudentButton.TabStop = true;
            ShadeStudentButton.Text = "Student";
            ShadeStudentButton.UseVisualStyleBackColor = true;
            ShadeStudentButton.CheckedChanged += ShadeStudentButton_CheckedChanged;
            // 
            // shortPasswordErrorLabel
            // 
            shortPasswordErrorLabel.AutoSize = true;
            shortPasswordErrorLabel.ForeColor = Color.DarkGray;
            shortPasswordErrorLabel.Location = new Point(9, 89);
            shortPasswordErrorLabel.Name = "shortPasswordErrorLabel";
            shortPasswordErrorLabel.Size = new Size(10, 15);
            shortPasswordErrorLabel.TabIndex = 29;
            shortPasswordErrorLabel.Text = " ";
            // 
            // usernameErrorLabel
            // 
            usernameErrorLabel.AutoSize = true;
            usernameErrorLabel.ForeColor = Color.DarkGray;
            usernameErrorLabel.Location = new Point(8, 48);
            usernameErrorLabel.Name = "usernameErrorLabel";
            usernameErrorLabel.Size = new Size(10, 15);
            usernameErrorLabel.TabIndex = 28;
            usernameErrorLabel.Text = " ";
            // 
            // PasswordsMatchntErrorLabel
            // 
            PasswordsMatchntErrorLabel.AutoSize = true;
            PasswordsMatchntErrorLabel.ForeColor = Color.DarkGray;
            PasswordsMatchntErrorLabel.Location = new Point(7, 131);
            PasswordsMatchntErrorLabel.Name = "PasswordsMatchntErrorLabel";
            PasswordsMatchntErrorLabel.Size = new Size(10, 15);
            PasswordsMatchntErrorLabel.TabIndex = 27;
            PasswordsMatchntErrorLabel.Text = " ";
            // 
            // lastNameErrorLabel
            // 
            lastNameErrorLabel.AutoSize = true;
            lastNameErrorLabel.ForeColor = Color.Red;
            lastNameErrorLabel.Location = new Point(166, 161);
            lastNameErrorLabel.Name = "lastNameErrorLabel";
            lastNameErrorLabel.Size = new Size(10, 15);
            lastNameErrorLabel.TabIndex = 26;
            lastNameErrorLabel.Text = " ";
            // 
            // firstNameErrorLabel
            // 
            firstNameErrorLabel.AutoSize = true;
            firstNameErrorLabel.ForeColor = Color.Red;
            firstNameErrorLabel.Location = new Point(9, 161);
            firstNameErrorLabel.Name = "firstNameErrorLabel";
            firstNameErrorLabel.Size = new Size(10, 15);
            firstNameErrorLabel.TabIndex = 25;
            firstNameErrorLabel.Text = " ";
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.FromArgb(103, 143, 59);
            clearButton.FlatStyle = FlatStyle.System;
            clearButton.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearButton.ForeColor = Color.FromArgb(103, 143, 59);
            clearButton.Location = new Point(9, 329);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(332, 36);
            clearButton.TabIndex = 23;
            clearButton.Text = "CLEAR";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Century Gothic", 8F);
            checkBox1.Location = new Point(231, 132);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(110, 20);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(103, 143, 59);
            button2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(10, 386);
            button2.Name = "button2";
            button2.Size = new Size(331, 36);
            button2.TabIndex = 21;
            button2.Text = "LOGIN";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(15, 368);
            label8.Name = "label8";
            label8.Size = new Size(167, 17);
            label8.TabIndex = 20;
            label8.Text = "Already have an account?";
            // 
            // emailAddress
            // 
            emailAddress.BackColor = SystemColors.Control;
            emailAddress.BorderStyle = BorderStyle.None;
            emailAddress.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailAddress.Location = new Point(15, 224);
            emailAddress.Name = "emailAddress";
            emailAddress.Size = new Size(320, 19);
            emailAddress.TabIndex = 18;
            emailAddress.TextChanged += emailAddress_TextChanged;
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.ActiveCaptionText;
            panel10.Location = new Point(11, 247);
            panel10.Name = "panel10";
            panel10.Size = new Size(326, 2);
            panel10.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(9, 197);
            label7.Name = "label7";
            label7.Size = new Size(116, 17);
            label7.TabIndex = 17;
            label7.Text = "VSU Email Address";
            // 
            // lastName
            // 
            lastName.BackColor = SystemColors.Control;
            lastName.BorderStyle = BorderStyle.None;
            lastName.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastName.Location = new Point(167, 172);
            lastName.Name = "lastName";
            lastName.Size = new Size(170, 19);
            lastName.TabIndex = 16;
            lastName.TextChanged += lastName_TextChanged;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ActiveCaptionText;
            panel9.Location = new Point(167, 191);
            panel9.Name = "panel9";
            panel9.Size = new Size(170, 2);
            panel9.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(167, 148);
            label6.Name = "label6";
            label6.Size = new Size(71, 17);
            label6.TabIndex = 15;
            label6.Text = "Last Name";
            // 
            // firstName
            // 
            firstName.BackColor = SystemColors.Control;
            firstName.BorderStyle = BorderStyle.None;
            firstName.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstName.Location = new Point(10, 172);
            firstName.Name = "firstName";
            firstName.Size = new Size(150, 19);
            firstName.TabIndex = 14;
            firstName.TextChanged += firstName_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(9, 148);
            label5.Name = "label5";
            label5.Size = new Size(70, 17);
            label5.TabIndex = 13;
            label5.Text = "First Name";
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ActiveCaptionText;
            panel8.Location = new Point(10, 191);
            panel8.Name = "panel8";
            panel8.Size = new Size(150, 2);
            panel8.TabIndex = 12;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveCaptionText;
            panel7.Location = new Point(10, 129);
            panel7.Name = "panel7";
            panel7.Size = new Size(326, 2);
            panel7.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Location = new Point(10, 87);
            panel5.Name = "panel5";
            panel5.Size = new Size(326, 2);
            panel5.TabIndex = 10;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaptionText;
            panel6.Location = new Point(11, 46);
            panel6.Name = "panel6";
            panel6.Size = new Size(326, 2);
            panel6.TabIndex = 9;
            // 
            // Password
            // 
            Password.BackColor = SystemColors.Control;
            Password.BorderStyle = BorderStyle.None;
            Password.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.ForeColor = SystemColors.ControlDarkDark;
            Password.Location = new Point(16, 62);
            Password.MaxLength = 50;
            Password.Name = "Password";
            Password.Size = new Size(320, 19);
            Password.TabIndex = 10;
            Password.Text = "Enter Password";
            Password.TextChanged += Password_TextChanged;
            // 
            // addUserName
            // 
            addUserName.BackColor = SystemColors.Control;
            addUserName.BorderStyle = BorderStyle.None;
            addUserName.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUserName.ForeColor = Color.DimGray;
            addUserName.Location = new Point(15, 21);
            addUserName.Name = "addUserName";
            addUserName.Size = new Size(320, 19);
            addUserName.TabIndex = 7;
            addUserName.Text = "Username";
            addUserName.TextChanged += addUserName_TextChanged;
            // 
            // Password2
            // 
            Password2.BackColor = SystemColors.Control;
            Password2.BorderStyle = BorderStyle.None;
            Password2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password2.ForeColor = SystemColors.WindowFrame;
            Password2.Location = new Point(15, 103);
            Password2.Name = "Password2";
            Password2.Size = new Size(320, 19);
            Password2.TabIndex = 12;
            Password2.Text = "Confirm Password";
            Password2.TextChanged += Password2_TextChanged;
            // 
            // emailAddressErrorLabel
            // 
            emailAddressErrorLabel.AutoSize = true;
            emailAddressErrorLabel.ForeColor = Color.Red;
            emailAddressErrorLabel.Location = new Point(11, 211);
            emailAddressErrorLabel.Name = "emailAddressErrorLabel";
            emailAddressErrorLabel.Size = new Size(10, 15);
            emailAddressErrorLabel.TabIndex = 24;
            emailAddressErrorLabel.Text = " ";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(103, 143, 59);
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(9, 291);
            button1.Name = "button1";
            button1.Size = new Size(332, 36);
            button1.TabIndex = 19;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(860, 494);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GigHub";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private TextBox Password;
        private Panel panel6;
        private TextBox addUserName;
        private Label label1;
        private Panel panel7;
        private TextBox Password2;
        private Panel panel8;
        private Label label5;
        private TextBox firstName;
        private TextBox lastName;
        private Panel panel9;
        private Label label6;
        private TextBox emailAddress;
        private Panel panel10;
        private Label label7;
        private Button button1;
        private Label label8;
        private Button button2;
        private CheckBox checkBox1;
        private Button clearButton;
        private Label emailAddressErrorLabel;
        private Label firstNameErrorLabel;
        private Label PasswordsMatchntErrorLabel;
        private Label lastNameErrorLabel;
        private Label shortPasswordErrorLabel;
        private Label usernameErrorLabel;
        private RadioButton ShadeStudentButton;
        private RadioButton ShadeFacultyButton;
        private Label RadioErrorLabel;
    }
}