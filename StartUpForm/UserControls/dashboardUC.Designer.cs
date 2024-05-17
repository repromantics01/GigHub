using System.Drawing.Drawing2D;

namespace StartUpForm
{
    partial class dashboardUC
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

        public class RoundedPanel : Panel
        {
            private int _cornerRadius = 10; // Adjust corner radius as needed

            public int CornerRadius
            {
                get { return _cornerRadius; }
                set { _cornerRadius = value; Invalidate(); } // Repaint the control when corner radius changes
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias; // Improves roundness quality

                // Define the rounded rectangle path
                var rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1); // Adjust for border
                var path = new GraphicsPath();
                path.AddArc(new Rectangle(_cornerRadius, _cornerRadius, _cornerRadius * 2, _cornerRadius * 2), 180, 90);
                path.AddArc(new Rectangle(rect.Right - _cornerRadius - 1, _cornerRadius, _cornerRadius * 2, _cornerRadius * 2), 270, 90);
                path.AddArc(new Rectangle(rect.Right - _cornerRadius - 1, rect.Bottom - _cornerRadius - 1, _cornerRadius * 2, _cornerRadius * 2), 0, 90);
                path.AddArc(new Rectangle(_cornerRadius, rect.Bottom - _cornerRadius - 1, _cornerRadius * 2, _cornerRadius * 2), 90, 90);
                path.CloseAllFigures();

                // Fill the rounded rectangle
                //g.FillPath(this.BackColor, path);

                // Draw the border (optional)
                // g.DrawPath(Pens.Black, path);
            }
        }


        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboardUC));
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            customPanel1 = new CustomControls.CustomPanel();
            rjButton2 = new CustomControls.RJButton();
            rjButton1 = new CustomControls.RJButton();
            customPanel2 = new CustomControls.CustomPanel();
            dashboardMainPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            customPanel1.SuspendLayout();
            customPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(200, 14);
            label1.Name = "label1";
            label1.Size = new Size(188, 23);
            label1.TabIndex = 1;
            label1.Text = "VSU Campus Gig Finder";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(20, 65);
            label2.Name = "label2";
            label2.Size = new Size(310, 32);
            label2.TabIndex = 2;
            label2.Text = "Student Name's Dashboard";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(240, 240, 168);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(326, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(240, 240, 168);
            pictureBox1.Image = Properties.Resources.bookmark_white;
            pictureBox1.Location = new Point(68, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // customPanel1
            // 
            customPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(pictureBox2);
            customPanel1.Controls.Add(rjButton2);
            customPanel1.Controls.Add(pictureBox1);
            customPanel1.Controls.Add(rjButton1);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.FromArgb(115, 138, 81);
            customPanel1.GradientTopColor = Color.FromArgb(115, 138, 81);
            customPanel1.Location = new Point(10, 100);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(551, 100);
            customPanel1.TabIndex = 0;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.FromArgb(240, 240, 168);
            rjButton2.BackgroundColor = Color.FromArgb(240, 240, 168);
            rjButton2.BorderColor = Color.FromArgb(0, 64, 0);
            rjButton2.BorderRadius = 10;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            rjButton2.ForeColor = SystemColors.ControlText;
            rjButton2.Location = new Point(283, 10);
            rjButton2.Name = "rjButton2";
            rjButton2.Padding = new Padding(30, 0, 0, 0);
            rjButton2.Size = new Size(253, 82);
            rjButton2.TabIndex = 5;
            rjButton2.Text = "Edit Profile";
            rjButton2.TextColor = SystemColors.ControlText;
            rjButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click_1;
            rjButton2.MouseLeave += rjButton2_MouseLeave;
            rjButton2.MouseHover += rjButton2_MouseHover;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(240, 240, 168);
            rjButton1.BackgroundColor = Color.FromArgb(240, 240, 168);
            rjButton1.BorderColor = Color.FromArgb(0, 64, 0);
            rjButton1.BorderRadius = 10;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            rjButton1.ForeColor = SystemColors.ControlText;
            rjButton1.Location = new Point(16, 9);
            rjButton1.Name = "rjButton1";
            rjButton1.Padding = new Padding(40, 0, 0, 0);
            rjButton1.Size = new Size(253, 82);
            rjButton1.TabIndex = 0;
            rjButton1.Text = "Saved Gigs";
            rjButton1.TextColor = SystemColors.ControlText;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            rjButton1.MouseLeave += rjButton1_MouseLeave;
            rjButton1.MouseHover += rjButton1_MouseHover;
            // 
            // customPanel2
            // 
            customPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel2.BackColor = Color.White;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(label1);
            customPanel2.ForeColor = Color.Black;
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.FromArgb(115, 138, 81);
            customPanel2.GradientTopColor = Color.FromArgb(115, 138, 81);
            customPanel2.Location = new Point(-22, -2);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(612, 51);
            customPanel2.TabIndex = 0;
            // 
            // dashboardMainPanel
            // 
            dashboardMainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dashboardMainPanel.BackColor = Color.FromArgb(247, 247, 237);
            dashboardMainPanel.Location = new Point(0, 206);
            dashboardMainPanel.Name = "dashboardMainPanel";
            dashboardMainPanel.Size = new Size(574, 335);
            dashboardMainPanel.TabIndex = 3;
            // 
            // dashboardUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 247, 237);
            Controls.Add(customPanel2);
            Controls.Add(customPanel1);
            Controls.Add(dashboardMainPanel);
            Controls.Add(label2);
            ForeColor = Color.FromArgb(247, 247, 237);
            Name = "dashboardUC";
            Size = new Size(574, 541);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            customPanel1.ResumeLayout(false);
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private CustomControls.CustomPanel customPanel1;
        private CustomControls.RJButton rjButton1;
        private CustomControls.RJButton rjButton2;
        private CustomControls.CustomPanel customPanel2;
        private Panel dashboardMainPanel;
        private UserControls.editProfile editProfile1;
    }
}
