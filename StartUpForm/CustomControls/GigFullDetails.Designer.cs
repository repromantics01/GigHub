namespace StartUpForm.CustomControls
{
    partial class GigFullDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GigFullDetails));
            customPanel1 = new CustomPanel();
            rjButton4 = new RJButton();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            startDate = new DateTimePicker();
            endDate = new DateTimePicker();
            rateLabel = new TextBox();
            rjButton3 = new RJButton();
            doneButton = new RJButton();
            reqsLabel = new RichTextBox();
            label6 = new Label();
            rjButton2 = new RJButton();
            label5 = new Label();
            label4 = new Label();
            locationLabel = new TextBox();
            label3 = new Label();
            descriptionTextBox = new RichTextBox();
            label2 = new Label();
            gigTitleLabel = new TextBox();
            rjButton1 = new RJButton();
            label10 = new Label();
            customPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // customPanel1
            // 
            customPanel1.AutoScroll = true;
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(rjButton4);
            customPanel1.Controls.Add(comboBox2);
            customPanel1.Controls.Add(comboBox1);
            customPanel1.Controls.Add(startDate);
            customPanel1.Controls.Add(endDate);
            customPanel1.Controls.Add(rateLabel);
            customPanel1.Controls.Add(rjButton3);
            customPanel1.Controls.Add(doneButton);
            customPanel1.Controls.Add(reqsLabel);
            customPanel1.Controls.Add(label6);
            customPanel1.Controls.Add(rjButton2);
            customPanel1.Controls.Add(label5);
            customPanel1.Controls.Add(label4);
            customPanel1.Controls.Add(locationLabel);
            customPanel1.Controls.Add(label3);
            customPanel1.Controls.Add(descriptionTextBox);
            customPanel1.Controls.Add(label2);
            customPanel1.Controls.Add(gigTitleLabel);
            customPanel1.Controls.Add(rjButton1);
            customPanel1.Controls.Add(label10);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.White;
            customPanel1.GradientTopColor = Color.White;
            customPanel1.Location = new Point(3, 3);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(581, 460);
            customPanel1.TabIndex = 0;
            // 
            // rjButton4
            // 
            rjButton4.BackColor = Color.DimGray;
            rjButton4.BackgroundColor = Color.DimGray;
            rjButton4.BorderColor = Color.FromArgb(115, 138, 81);
            rjButton4.BorderRadius = 5;
            rjButton4.BorderSize = 0;
            rjButton4.FlatAppearance.BorderSize = 0;
            rjButton4.FlatStyle = FlatStyle.Flat;
            rjButton4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton4.ForeColor = Color.White;
            rjButton4.Location = new Point(134, 46);
            rjButton4.Name = "rjButton4";
            rjButton4.Size = new Size(100, 24);
            rjButton4.TabIndex = 31;
            rjButton4.Text = "Mark as Close";
            rjButton4.TextColor = Color.White;
            rjButton4.UseVisualStyleBackColor = false;
            rjButton4.Click += rjButton4_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "on_site", "remote", "flexible" });
            comboBox2.Location = new Point(19, 46);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(109, 23);
            comboBox2.TabIndex = 30;
            comboBox2.Text = "Edit Gig Type";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(116, -93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(79, 23);
            comboBox1.TabIndex = 29;
            comboBox1.Text = "Gig Type";
            // 
            // startDate
            // 
            startDate.Location = new Point(93, 211);
            startDate.Name = "startDate";
            startDate.Size = new Size(193, 23);
            startDate.TabIndex = 28;
            // 
            // endDate
            // 
            endDate.Location = new Point(358, 211);
            endDate.Name = "endDate";
            endDate.Size = new Size(200, 23);
            endDate.TabIndex = 27;
            // 
            // rateLabel
            // 
            rateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rateLabel.BackColor = Color.White;
            rateLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rateLabel.Location = new Point(492, 46);
            rateLabel.Name = "rateLabel";
            rateLabel.Size = new Size(64, 25);
            rateLabel.TabIndex = 26;
            rateLabel.Text = "00.00";
            // 
            // rjButton3
            // 
            rjButton3.BackColor = Color.Red;
            rjButton3.BackgroundColor = Color.Red;
            rjButton3.BorderColor = Color.FromArgb(115, 138, 81);
            rjButton3.BorderRadius = 5;
            rjButton3.BorderSize = 0;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton3.ForeColor = Color.White;
            rjButton3.Location = new Point(483, 13);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(74, 24);
            rjButton3.TabIndex = 24;
            rjButton3.Text = "Delete Gig";
            rjButton3.TextColor = Color.White;
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.Click += rjButton3_Click;
            // 
            // doneButton
            // 
            doneButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            doneButton.BackColor = Color.FromArgb(115, 138, 81);
            doneButton.BackgroundColor = Color.FromArgb(115, 138, 81);
            doneButton.BorderColor = Color.FromArgb(0, 64, 0);
            doneButton.BorderRadius = 5;
            doneButton.BorderSize = 0;
            doneButton.FlatAppearance.BorderSize = 0;
            doneButton.FlatStyle = FlatStyle.Flat;
            doneButton.ForeColor = Color.White;
            doneButton.Location = new Point(207, 412);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(153, 35);
            doneButton.TabIndex = 23;
            doneButton.Text = "Save";
            doneButton.TextColor = Color.White;
            doneButton.UseVisualStyleBackColor = false;
            doneButton.Click += doneButton_Click_1;
            // 
            // reqsLabel
            // 
            reqsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            reqsLabel.BackColor = Color.White;
            reqsLabel.BorderStyle = BorderStyle.None;
            reqsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reqsLabel.Location = new Point(25, 273);
            reqsLabel.Name = "reqsLabel";
            reqsLabel.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            reqsLabel.Size = new Size(529, 121);
            reqsLabel.TabIndex = 18;
            reqsLabel.Text = resources.GetString("reqsLabel.Text");
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoEllipsis = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 247);
            label6.Name = "label6";
            label6.Size = new Size(340, 27);
            label6.TabIndex = 17;
            label6.Text = "Requirements and Qualifications: ";
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.White;
            rjButton2.BackgroundColor = Color.White;
            rjButton2.BorderColor = Color.FromArgb(115, 138, 81);
            rjButton2.BorderRadius = 5;
            rjButton2.BorderSize = 2;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.ForeColor = Color.White;
            rjButton2.Location = new Point(17, 240);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(541, 165);
            rjButton2.TabIndex = 19;
            rjButton2.Text = "rjButton2";
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoEllipsis = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(291, 212);
            label5.Name = "label5";
            label5.Size = new Size(86, 22);
            label5.TabIndex = 14;
            label5.Text = "End Date:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoEllipsis = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(19, 212);
            label4.Name = "label4";
            label4.Size = new Size(86, 22);
            label4.TabIndex = 13;
            label4.Text = "Start Date:";
            // 
            // locationLabel
            // 
            locationLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            locationLabel.BackColor = Color.White;
            locationLabel.BorderStyle = BorderStyle.None;
            locationLabel.Font = new Font("Segoe UI", 10F);
            locationLabel.Location = new Point(90, 186);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(299, 18);
            locationLabel.TabIndex = 12;
            locationLabel.Text = "[Location Details]";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoEllipsis = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(20, 186);
            label3.Name = "label3";
            label3.Size = new Size(85, 22);
            label3.TabIndex = 9;
            label3.Text = "Location:";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            descriptionTextBox.BackColor = Color.White;
            descriptionTextBox.BorderStyle = BorderStyle.None;
            descriptionTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionTextBox.Location = new Point(25, 103);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            descriptionTextBox.Size = new Size(522, 70);
            descriptionTextBox.TabIndex = 8;
            descriptionTextBox.Text = resources.GetString("descriptionTextBox.Text");
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoEllipsis = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 78);
            label2.Name = "label2";
            label2.Size = new Size(112, 27);
            label2.TabIndex = 7;
            label2.Text = "Description";
            // 
            // gigTitleLabel
            // 
            gigTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gigTitleLabel.BackColor = Color.White;
            gigTitleLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gigTitleLabel.Location = new Point(18, 9);
            gigTitleLabel.Name = "gigTitleLabel";
            gigTitleLabel.Size = new Size(460, 35);
            gigTitleLabel.TabIndex = 2;
            gigTitleLabel.Text = "Gig Title";
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.White;
            rjButton1.BackgroundColor = Color.White;
            rjButton1.BorderColor = Color.FromArgb(115, 138, 81);
            rjButton1.BorderRadius = 5;
            rjButton1.BorderSize = 2;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(17, 75);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(540, 108);
            rjButton1.TabIndex = 11;
            rjButton1.Text = "rjButton1";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoEllipsis = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(393, 49);
            label10.Name = "label10";
            label10.Size = new Size(102, 22);
            label10.TabIndex = 25;
            label10.Text = "Hourly Rate:";
            // 
            // GigFullDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 471);
            Controls.Add(customPanel1);
            Name = "GigFullDetails";
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CustomPanel customPanel1;
        private TextBox gigTitleLabel;
        private Label label2;
        private Label label3;
        private RichTextBox descriptionTextBox;
        private RJButton rjButton1;
        private Label label4;
        private TextBox locationLabel;
        private Label label8;
        private Label label7;
        private RichTextBox reqsLabel;
        private Label label6;
        private RJButton rjButton2;
        private Label label5;
        private RJButton rjButton3;
        private RJButton doneButton;
        private TextBox rateLabel;
        private Label label10;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker endDate;
        private DateTimePicker startDate;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private RJButton rjButton4;
    }
}
