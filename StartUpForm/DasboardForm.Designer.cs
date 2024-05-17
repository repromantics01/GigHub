namespace StartUpForm
{
    partial class DasboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DasboardForm));
            menuPanel = new Panel();
            rjCircularPictureBox2 = new CustomControls.RJCircularPictureBox();
            rjCircularPictureBox1 = new CustomControls.RJCircularPictureBox();
            pictureBox3 = new PictureBox();
            button3 = new Button();
            usersName = new Label();
            logoPanel = new Panel();
            pictureBox4 = new PictureBox();
            button1 = new Button();
            dashboardButton = new Button();
            DashboardMain = new Panel();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            menuPanel.BackColor = Color.FromArgb(115, 138, 81);
            menuPanel.Controls.Add(rjCircularPictureBox2);
            menuPanel.Controls.Add(rjCircularPictureBox1);
            menuPanel.Controls.Add(pictureBox3);
            menuPanel.Controls.Add(button3);
            menuPanel.Controls.Add(logoPanel);
            menuPanel.Controls.Add(button1);
            menuPanel.Controls.Add(dashboardButton);
            menuPanel.Location = new Point(0, 0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(226, 541);
            menuPanel.TabIndex = 0;
            // 
            // rjCircularPictureBox2
            // 
            rjCircularPictureBox2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircularPictureBox2.BorderColor = Color.White;
            rjCircularPictureBox2.BorderColor2 = Color.White;
            rjCircularPictureBox2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rjCircularPictureBox2.BorderSize = 2;
            rjCircularPictureBox2.GradientAngle = 50F;
            rjCircularPictureBox2.Image = (Image)resources.GetObject("rjCircularPictureBox2.Image");
            rjCircularPictureBox2.Location = new Point(39, 226);
            rjCircularPictureBox2.Name = "rjCircularPictureBox2";
            rjCircularPictureBox2.Size = new Size(42, 42);
            rjCircularPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            rjCircularPictureBox2.TabIndex = 10;
            rjCircularPictureBox2.TabStop = false;
            // 
            // rjCircularPictureBox1
            // 
            rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircularPictureBox1.BorderColor = Color.White;
            rjCircularPictureBox1.BorderColor2 = Color.White;
            rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rjCircularPictureBox1.BorderSize = 2;
            rjCircularPictureBox1.GradientAngle = 50F;
            rjCircularPictureBox1.Image = (Image)resources.GetObject("rjCircularPictureBox1.Image");
            rjCircularPictureBox1.Location = new Point(39, 161);
            rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            rjCircularPictureBox1.Size = new Size(42, 42);
            rjCircularPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            rjCircularPictureBox1.TabIndex = 9;
            rjCircularPictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(102, 505);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(131, 499);
            button3.Name = "button3";
            button3.Size = new Size(95, 42);
            button3.TabIndex = 7;
            button3.Text = "Sign Out";
            button3.UseVisualStyleBackColor = true;
            // 
            // usersName
            // 
            usersName.AutoSize = true;
            usersName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usersName.ForeColor = Color.White;
            usersName.Location = new Point(23, 93);
            usersName.Name = "usersName";
            usersName.Size = new Size(169, 21);
            usersName.TabIndex = 1;
            usersName.Text = "Welcome to GigHub!";
            // 
            // logoPanel
            // 
            logoPanel.Controls.Add(usersName);
            logoPanel.Controls.Add(pictureBox4);
            logoPanel.Location = new Point(0, 14);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(220, 133);
            logoPanel.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.VSU_Gig_Hub_Icon_removebg_preview;
            pictureBox4.Location = new Point(39, -14);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(129, 126);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(3, 219);
            button1.Name = "button1";
            button1.Size = new Size(223, 60);
            button1.TabIndex = 3;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dashboardButton
            // 
            dashboardButton.Cursor = Cursors.Hand;
            dashboardButton.FlatAppearance.BorderSize = 0;
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardButton.ForeColor = Color.White;
            dashboardButton.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardButton.Location = new Point(3, 153);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Padding = new Padding(25, 0, 0, 0);
            dashboardButton.Size = new Size(223, 60);
            dashboardButton.TabIndex = 1;
            dashboardButton.Text = "Dashboard";
            dashboardButton.UseVisualStyleBackColor = true;
            dashboardButton.Click += dashboardButton_Click;
            // 
            // DashboardMain
            // 
            DashboardMain.Dock = DockStyle.Right;
            DashboardMain.Location = new Point(226, 0);
            DashboardMain.Name = "DashboardMain";
            DashboardMain.Size = new Size(574, 541);
            DashboardMain.TabIndex = 1;
            // 
            // DasboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 541);
            Controls.Add(DashboardMain);
            Controls.Add(menuPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DasboardForm";
            menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)rjCircularPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            logoPanel.ResumeLayout(false);
            logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel menuPanel;
        private Button dashboardButton;
        private Panel logoPanel;
        private Button button1;
        private PictureBox pictureBox4;
        private Label usersName;
        private Button button3;
        private Panel DashboardMain;
        private dashboardUC dashboarduc1;
        private PictureBox pictureBox3;
        private CustomControls.RJCircularPictureBox rjCircularPictureBox1;
        private CustomControls.RJCircularPictureBox rjCircularPictureBox2;
    }
}