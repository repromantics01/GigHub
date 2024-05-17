namespace StartUpForm.UserControls
{
    partial class savedGigUCFINAL
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
            customPanel1 = new CustomControls.CustomPanel();
            flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label4 = new Label();
            customPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // customPanel1
            // 
            customPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(flowLayoutPanel);
            customPanel1.Controls.Add(flowLayoutPanel2);
            customPanel1.Controls.Add(label4);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.FromArgb(240, 240, 168);
            customPanel1.GradientTopColor = Color.White;
            customPanel1.Location = new Point(15, 7);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(558, 325);
            customPanel1.TabIndex = 30;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.BackColor = Color.Transparent;
            flowLayoutPanel.Location = new Point(5, 50);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(545, 258);
            flowLayoutPanel.TabIndex = 30;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.BackColor = Color.FromArgb(0, 64, 0);
            flowLayoutPanel2.ForeColor = Color.FromArgb(0, 64, 0);
            flowLayoutPanel2.Location = new Point(12, 41);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(530, 3);
            flowLayoutPanel2.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 64, 0);
            label4.Location = new Point(5, 8);
            label4.Name = "label4";
            label4.Size = new Size(189, 32);
            label4.TabIndex = 3;
            label4.Text = "Your Saved Gigs";
            // 
            // savedGigUCFINAL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(customPanel1);
            Name = "savedGigUCFINAL";
            Size = new Size(583, 335);
            Load += savedGigUCFINAL_Load;
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public CustomControls.CustomPanel customPanel1;
        public FlowLayoutPanel flowLayoutPanel2;
        public Label label4;
        public FlowLayoutPanel flowLayoutPanel;
    }
}
