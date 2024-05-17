namespace StartUpForm.CustomControls
{
    partial class GigCustomList
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
            gigTitleLabel = new Label();
            customPanel1 = new CustomPanel();
            button1 = new Button();
            panel1 = new Panel();
            descriptionTextBox = new Label();
            typeLabel = new Label();
            dateLabel = new Label();
            customPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // gigTitleLabel
            // 
            gigTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gigTitleLabel.AutoEllipsis = true;
            gigTitleLabel.BackColor = Color.FromArgb(240, 240, 168);
            gigTitleLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gigTitleLabel.ForeColor = Color.FromArgb(0, 64, 0);
            gigTitleLabel.Location = new Point(20, 8);
            gigTitleLabel.Name = "gigTitleLabel";
            gigTitleLabel.Size = new Size(316, 28);
            gigTitleLabel.TabIndex = 1;
            gigTitleLabel.Text = "Gig Title";
            // 
            // customPanel1
            // 
            customPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(button1);
            customPanel1.Controls.Add(panel1);
            customPanel1.Controls.Add(descriptionTextBox);
            customPanel1.Controls.Add(typeLabel);
            customPanel1.Controls.Add(dateLabel);
            customPanel1.Controls.Add(gigTitleLabel);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.FromArgb(240, 240, 168);
            customPanel1.GradientTopColor = Color.FromArgb(240, 240, 168);
            customPanel1.Location = new Point(0, 0);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(520, 91);
            customPanel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(115, 138, 81);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(422, 58);
            button1.Name = "button1";
            button1.Size = new Size(85, 26);
            button1.TabIndex = 9;
            button1.Text = "Edit Details";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.ForeColor = Color.FromArgb(0, 64, 0);
            panel1.Location = new Point(15, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(492, 2);
            panel1.TabIndex = 8;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.AutoEllipsis = true;
            descriptionTextBox.BackColor = Color.FromArgb(240, 240, 168);
            descriptionTextBox.Font = new Font("Segoe UI", 9.75F);
            descriptionTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            descriptionTextBox.Location = new Point(20, 42);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(396, 43);
            descriptionTextBox.TabIndex = 7;
            descriptionTextBox.Text = "Gig Description Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia, molestiae quas vel sint...";
            // 
            // typeLabel
            // 
            typeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            typeLabel.AutoEllipsis = true;
            typeLabel.BackColor = Color.FromArgb(240, 240, 168);
            typeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            typeLabel.Location = new Point(457, 14);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(50, 18);
            typeLabel.TabIndex = 5;
            typeLabel.Text = "On-site";
            // 
            // dateLabel
            // 
            dateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateLabel.AutoEllipsis = true;
            dateLabel.BackColor = Color.FromArgb(240, 240, 168);
            dateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(342, 13);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(119, 18);
            dateLabel.TabIndex = 2;
            dateLabel.Text = "Posted: [2024/00/00],";
            // 
            // GigCustomList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(customPanel1);
            Name = "GigCustomList";
            Size = new Size(520, 91);
            customPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Label gigTitleLabel;
        private CustomPanel customPanel1;
        public Label dateLabel;
        public Label descriptionLabel;
        public Label typeLabel;
        private Panel panel1;
        public Label descriptionTextBox;
        public Button button1;
    }
}
