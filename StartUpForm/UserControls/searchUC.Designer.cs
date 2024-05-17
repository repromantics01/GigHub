namespace StartUpForm.UserControls
{
    partial class searchUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            customPanel1 = new CustomControls.CustomPanel();
            searchButton = new CustomControls.RJButton();
            searchTextBox = new TextBox();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label4 = new Label();
            customPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(146, 38);
            label1.Name = "label1";
            label1.Size = new Size(285, 32);
            label1.TabIndex = 0;
            label1.Text = "Search for Campus Gigs";
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(searchButton);
            customPanel1.Controls.Add(searchTextBox);
            customPanel1.Controls.Add(label1);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.FromArgb(0, 64, 0);
            customPanel1.GradientTopColor = Color.FromArgb(115, 138, 81);
            customPanel1.Location = new Point(-10, 31);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(600, 173);
            customPanel1.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(240, 240, 168);
            searchButton.BackgroundColor = Color.FromArgb(240, 240, 168);
            searchButton.BorderColor = Color.PaleVioletRed;
            searchButton.BorderRadius = 0;
            searchButton.BorderSize = 0;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.ForeColor = Color.Black;
            searchButton.Location = new Point(436, 77);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(60, 25);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search";
            searchButton.TextColor = Color.Black;
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTextBox.Location = new Point(128, 77);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(302, 25);
            searchTextBox.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 203);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 335);
            panel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(13, 64);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(545, 258);
            flowLayoutPanel1.TabIndex = 32;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.BackColor = Color.FromArgb(0, 64, 0);
            flowLayoutPanel2.ForeColor = Color.FromArgb(0, 64, 0);
            flowLayoutPanel2.Location = new Point(22, 50);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(525, 3);
            flowLayoutPanel2.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 64, 0);
            label4.Location = new Point(15, 15);
            label4.Name = "label4";
            label4.Size = new Size(142, 32);
            label4.TabIndex = 27;
            label4.Text = "Recent Gigs";
            // 
            // searchUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(customPanel1);
            Name = "searchUC";
            Size = new Size(574, 541);
            Load += searchUC_Load;
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private CustomControls.CustomPanel customPanel1;
        private TextBox searchTextBox;
        private Panel panel1;
        public FlowLayoutPanel flowLayoutPanel2;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel1;
        private CustomControls.RJButton searchButton;
    }
}
