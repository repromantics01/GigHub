namespace StartUpForm.UserControls
{
    partial class GigFullDetails_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GigFullDetails_Student));
            customPanel1 = new CustomControls.CustomPanel();
            messengerLinkLabel = new LinkLabel();
            label8 = new Label();
            emailLabel = new Label();
            locationLabel = new Label();
            rateLabel = new Label();
            rjButton3 = new CustomControls.RJButton();
            doneButton = new CustomControls.RJButton();
            statusLabel = new CustomControls.RJButton();
            label7 = new Label();
            reqsLabel = new RichTextBox();
            label6 = new Label();
            rjButton2 = new CustomControls.RJButton();
            endDateLabel = new Label();
            startDateLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            descriptionTextBox = new RichTextBox();
            label2 = new Label();
            typeLabel = new CustomControls.RJButton();
            datePostedLabel = new Label();
            nameOfCreatorLabel = new Label();
            label1 = new Label();
            gigTitleLabel = new Label();
            rjButton1 = new CustomControls.RJButton();
            label10 = new Label();
            customPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // customPanel1
            // 
            customPanel1.AutoScroll = true;
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(messengerLinkLabel);
            customPanel1.Controls.Add(label8);
            customPanel1.Controls.Add(emailLabel);
            customPanel1.Controls.Add(locationLabel);
            customPanel1.Controls.Add(rateLabel);
            customPanel1.Controls.Add(rjButton3);
            customPanel1.Controls.Add(doneButton);
            customPanel1.Controls.Add(statusLabel);
            customPanel1.Controls.Add(label7);
            customPanel1.Controls.Add(reqsLabel);
            customPanel1.Controls.Add(label6);
            customPanel1.Controls.Add(rjButton2);
            customPanel1.Controls.Add(endDateLabel);
            customPanel1.Controls.Add(startDateLabel);
            customPanel1.Controls.Add(label5);
            customPanel1.Controls.Add(label4);
            customPanel1.Controls.Add(label3);
            customPanel1.Controls.Add(descriptionTextBox);
            customPanel1.Controls.Add(label2);
            customPanel1.Controls.Add(typeLabel);
            customPanel1.Controls.Add(datePostedLabel);
            customPanel1.Controls.Add(nameOfCreatorLabel);
            customPanel1.Controls.Add(label1);
            customPanel1.Controls.Add(gigTitleLabel);
            customPanel1.Controls.Add(rjButton1);
            customPanel1.Controls.Add(label10);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.White;
            customPanel1.GradientTopColor = Color.White;
            customPanel1.Location = new Point(4, 7);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(579, 455);
            customPanel1.TabIndex = 1;
            // 
            // messengerLinkLabel
            // 
            messengerLinkLabel.Location = new Point(457, 207);
            messengerLinkLabel.Name = "messengerLinkLabel";
            messengerLinkLabel.Size = new Size(100, 17);
            messengerLinkLabel.TabIndex = 30;
            messengerLinkLabel.TabStop = true;
            messengerLinkLabel.Text = "linkLabel1";
            messengerLinkLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9.75F);
            label8.Location = new Point(351, 206);
            label8.Name = "label8";
            label8.Size = new Size(100, 19);
            label8.TabIndex = 29;
            label8.Text = ", 00000000000, ";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // emailLabel
            // 
            emailLabel.AutoEllipsis = true;
            emailLabel.Font = new Font("Segoe UI", 9.75F);
            emailLabel.Location = new Point(123, 206);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(226, 19);
            emailLabel.TabIndex = 28;
            emailLabel.Text = "sample_faculty_user@vsu.edu.ph";
            emailLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // locationLabel
            // 
            locationLabel.Font = new Font("Segoe UI", 9.75F);
            locationLabel.Location = new Point(79, 185);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(448, 19);
            locationLabel.TabIndex = 27;
            locationLabel.Text = "label9";
            // 
            // rateLabel
            // 
            rateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rateLabel.AutoEllipsis = true;
            rateLabel.BackColor = Color.White;
            rateLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rateLabel.Location = new Point(521, 50);
            rateLabel.Name = "rateLabel";
            rateLabel.Size = new Size(49, 22);
            rateLabel.TabIndex = 26;
            rateLabel.Text = "00.00";
            // 
            // rjButton3
            // 
            rjButton3.BackColor = Color.FromArgb(115, 138, 81);
            rjButton3.BackgroundColor = Color.FromArgb(115, 138, 81);
            rjButton3.BorderColor = Color.FromArgb(115, 138, 81);
            rjButton3.BorderRadius = 5;
            rjButton3.BorderSize = 0;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton3.ForeColor = Color.White;
            rjButton3.Location = new Point(483, 20);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(74, 24);
            rjButton3.TabIndex = 24;
            rjButton3.Text = "Save Gig";
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
            doneButton.Location = new Point(193, 402);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(171, 35);
            doneButton.TabIndex = 23;
            doneButton.Text = "Done";
            doneButton.TextColor = Color.White;
            doneButton.UseVisualStyleBackColor = false;
            doneButton.Click += doneButton_Click;
            // 
            // statusLabel
            // 
            statusLabel.BackColor = Color.White;
            statusLabel.BackgroundColor = Color.White;
            statusLabel.BorderColor = Color.FromArgb(115, 138, 81);
            statusLabel.BorderRadius = 12;
            statusLabel.BorderSize = 2;
            statusLabel.FlatAppearance.BorderSize = 0;
            statusLabel.FlatStyle = FlatStyle.Flat;
            statusLabel.ForeColor = Color.Black;
            statusLabel.Location = new Point(351, 47);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(86, 24);
            statusLabel.TabIndex = 22;
            statusLabel.Text = "GigStatus";
            statusLabel.TextColor = Color.Black;
            statusLabel.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoEllipsis = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.Location = new Point(16, 206);
            label7.Name = "label7";
            label7.Size = new Size(156, 22);
            label7.TabIndex = 20;
            label7.Text = "Contact Details: ";
            // 
            // reqsLabel
            // 
            reqsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            reqsLabel.BackColor = Color.White;
            reqsLabel.BorderStyle = BorderStyle.None;
            reqsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reqsLabel.Location = new Point(25, 289);
            reqsLabel.Name = "reqsLabel";
            reqsLabel.ReadOnly = true;
            reqsLabel.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            reqsLabel.Size = new Size(521, 96);
            reqsLabel.TabIndex = 18;
            reqsLabel.Text = resources.GetString("reqsLabel.Text");
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoEllipsis = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 262);
            label6.Name = "label6";
            label6.Size = new Size(358, 27);
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
            rjButton2.Location = new Point(17, 255);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(540, 141);
            rjButton2.TabIndex = 19;
            rjButton2.Text = "rjButton2";
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            // 
            // endDateLabel
            // 
            endDateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            endDateLabel.AutoEllipsis = true;
            endDateLabel.BackColor = Color.White;
            endDateLabel.Font = new Font("Segoe UI", 10F);
            endDateLabel.Location = new Point(369, 228);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(122, 22);
            endDateLabel.TabIndex = 16;
            endDateLabel.Text = "[04-23-2024]";
            // 
            // startDateLabel
            // 
            startDateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            startDateLabel.AutoEllipsis = true;
            startDateLabel.BackColor = Color.White;
            startDateLabel.Font = new Font("Segoe UI", 10F);
            startDateLabel.Location = new Point(105, 228);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(142, 22);
            startDateLabel.TabIndex = 15;
            startDateLabel.Text = "[04-22-2024]";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoEllipsis = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(294, 227);
            label5.Name = "label5";
            label5.Size = new Size(104, 22);
            label5.TabIndex = 14;
            label5.Text = "End Date:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoEllipsis = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(18, 229);
            label4.Name = "label4";
            label4.Size = new Size(104, 22);
            label4.TabIndex = 13;
            label4.Text = "Start Date:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoEllipsis = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(17, 184);
            label3.Name = "label3";
            label3.Size = new Size(103, 22);
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
            descriptionTextBox.ReadOnly = true;
            descriptionTextBox.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            descriptionTextBox.Size = new Size(521, 70);
            descriptionTextBox.TabIndex = 8;
            descriptionTextBox.Text = resources.GetString("descriptionTextBox.Text");
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoEllipsis = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 79);
            label2.Name = "label2";
            label2.Size = new Size(130, 27);
            label2.TabIndex = 7;
            label2.Text = "Description";
            // 
            // typeLabel
            // 
            typeLabel.BackColor = Color.White;
            typeLabel.BackgroundColor = Color.White;
            typeLabel.BorderColor = Color.FromArgb(115, 138, 81);
            typeLabel.BorderRadius = 12;
            typeLabel.BorderSize = 2;
            typeLabel.FlatAppearance.BorderSize = 0;
            typeLabel.FlatStyle = FlatStyle.Flat;
            typeLabel.ForeColor = Color.Black;
            typeLabel.Location = new Point(263, 47);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(86, 24);
            typeLabel.TabIndex = 6;
            typeLabel.Text = "GigType";
            typeLabel.TextColor = Color.Black;
            typeLabel.UseVisualStyleBackColor = false;
            // 
            // datePostedLabel
            // 
            datePostedLabel.AutoSize = true;
            datePostedLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            datePostedLabel.Location = new Point(182, 52);
            datePostedLabel.Name = "datePostedLabel";
            datePostedLabel.Size = new Size(81, 15);
            datePostedLabel.TabIndex = 5;
            datePostedLabel.Text = "[2024-05-09]";
            // 
            // nameOfCreatorLabel
            // 
            nameOfCreatorLabel.AutoSize = true;
            nameOfCreatorLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            nameOfCreatorLabel.Location = new Point(88, 52);
            nameOfCreatorLabel.Name = "nameOfCreatorLabel";
            nameOfCreatorLabel.Size = new Size(95, 15);
            nameOfCreatorLabel.TabIndex = 4;
            nameOfCreatorLabel.Text = "[fName, lName],";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 52);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 3;
            label1.Text = "Posted by: ";
            // 
            // gigTitleLabel
            // 
            gigTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gigTitleLabel.AutoEllipsis = true;
            gigTitleLabel.BackColor = Color.White;
            gigTitleLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gigTitleLabel.Location = new Point(13, 13);
            gigTitleLabel.Name = "gigTitleLabel";
            gigTitleLabel.Size = new Size(450, 31);
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
            label10.Location = new Point(441, 50);
            label10.Name = "label10";
            label10.Size = new Size(105, 22);
            label10.TabIndex = 25;
            label10.Text = "Hourly Rate:";
            // 
            // GigFullDetails_Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 474);
            Controls.Add(customPanel1);
            Name = "GigFullDetails_Student";
            StartPosition = FormStartPosition.CenterParent;
            Text = "GigFullDetails_Student";
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CustomPanel customPanel1;
        private Label rateLabel;
        private CustomControls.RJButton rjButton3;
        private CustomControls.RJButton doneButton;
        private CustomControls.RJButton statusLabel;
        private Label label7;
        private RichTextBox reqsLabel;
        private Label label6;
        private CustomControls.RJButton rjButton2;
        private Label endDateLabel;
        private Label startDateLabel;
        private Label label5;
        private Label label4;
        private Label label3;
        private RichTextBox descriptionTextBox;
        private Label label2;
        private CustomControls.RJButton typeLabel;
        private Label datePostedLabel;
        private Label nameOfCreatorLabel;
        private Label label1;
        private Label gigTitleLabel;
        private CustomControls.RJButton rjButton1;
        private Label label10;
        private Label locationLabel;
        private Label label8;
        private Label emailLabel;
        private LinkLabel messengerLinkLabel;
    }
}