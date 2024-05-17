namespace StartUpForm
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            userName = new TextBox();
            panel3 = new Panel();
            emptyPasswordErrorLabel = new Label();
            panel5 = new Panel();
            button1 = new Button();
            password = new TextBox();
            panel4 = new Panel();
            emptyUsernamErrorLabel = new Label();
            label4 = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
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
            panel1.TabIndex = 1;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22F, FontStyle.Bold);
            label1.Location = new Point(398, 123);
            label1.Name = "label1";
            label1.Size = new Size(110, 37);
            label1.TabIndex = 2;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 17);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11F);
            label3.Location = new Point(51, 64);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(10, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.key;
            pictureBox3.Location = new Point(11, 56);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // userName
            // 
            userName.BackColor = SystemColors.Control;
            userName.BorderStyle = BorderStyle.None;
            userName.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userName.Location = new Point(133, 17);
            userName.Name = "userName";
            userName.Size = new Size(202, 19);
            userName.TabIndex = 7;
            userName.TextChanged += userName_TextChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(emptyPasswordErrorLabel);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(password);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(userName);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(emptyUsernamErrorLabel);
            panel3.Location = new Point(398, 163);
            panel3.Name = "panel3";
            panel3.Size = new Size(351, 149);
            panel3.TabIndex = 9;
            // 
            // emptyPasswordErrorLabel
            // 
            emptyPasswordErrorLabel.AutoSize = true;
            emptyPasswordErrorLabel.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emptyPasswordErrorLabel.ForeColor = Color.Red;
            emptyPasswordErrorLabel.Location = new Point(53, 94);
            emptyPasswordErrorLabel.Name = "emptyPasswordErrorLabel";
            emptyPasswordErrorLabel.Size = new Size(10, 16);
            emptyPasswordErrorLabel.TabIndex = 12;
            emptyPasswordErrorLabel.Text = " ";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Location = new Point(10, 92);
            panel5.Name = "panel5";
            panel5.Size = new Size(326, 2);
            panel5.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(103, 143, 59);
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(9, 110);
            button1.Name = "button1";
            button1.Size = new Size(326, 36);
            button1.TabIndex = 10;
            button1.Text = "ENTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // password
            // 
            password.BackColor = SystemColors.Control;
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(133, 63);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(202, 19);
            password.TabIndex = 10;
            password.TextChanged += password_TextChanged;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(11, 45);
            panel4.Name = "panel4";
            panel4.Size = new Size(326, 2);
            panel4.TabIndex = 9;
            // 
            // emptyUsernamErrorLabel
            // 
            emptyUsernamErrorLabel.AutoSize = true;
            emptyUsernamErrorLabel.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emptyUsernamErrorLabel.ForeColor = Color.Red;
            emptyUsernamErrorLabel.Location = new Point(51, 49);
            emptyUsernamErrorLabel.Name = "emptyUsernamErrorLabel";
            emptyUsernamErrorLabel.Size = new Size(10, 16);
            emptyUsernamErrorLabel.TabIndex = 11;
            emptyUsernamErrorLabel.Text = " ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(409, 315);
            label4.Name = "label4";
            label4.Size = new Size(135, 17);
            label4.TabIndex = 11;
            label4.Text = "New to VSU Gig Hub?";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(103, 143, 59);
            button2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(409, 335);
            button2.Name = "button2";
            button2.Size = new Size(326, 36);
            button2.TabIndex = 11;
            button2.Text = "SIGN-UP";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 494);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GigHub";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox userName;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private TextBox password;
        private Panel panel4;
        private Button button1;
        private Label label4;
        private Button button2;
        private Label emptyUsernamErrorLabel;
        private Label emptyPasswordErrorLabel;
    }
}