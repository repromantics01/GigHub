namespace StartUpForm
{
    partial class createGigForm
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
            rateBox = new TextBox();
            label6 = new Label();
            reqsBox = new RichTextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            gigTypeBox = new ComboBox();
            endDateBox = new Label();
            dateTimePicker2 = new DateTimePicker();
            panel3 = new Panel();
            locationBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            startDateBox = new DateTimePicker();
            descriptionBox = new RichTextBox();
            label1 = new Label();
            customPanel1 = new CustomControls.CustomPanel();
            titleBox = new TextBox();
            panel1.SuspendLayout();
            customPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(rateBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(reqsBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(gigTypeBox);
            panel1.Controls.Add(endDateBox);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(locationBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(startDateBox);
            panel1.Controls.Add(descriptionBox);
            panel1.Controls.Add(customPanel1);
            panel1.Location = new Point(-3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 335);
            panel1.TabIndex = 13;
            // 
            // rateBox
            // 
            rateBox.BorderStyle = BorderStyle.FixedSingle;
            rateBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rateBox.Location = new Point(66, 298);
            rateBox.Name = "rateBox";
            rateBox.Size = new Size(110, 25);
            rateBox.TabIndex = 11;
            rateBox.Text = "0.00";
            rateBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(240, 240, 168);
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label6.Location = new Point(19, 302);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 10;
            label6.Text = "Rate";
            // 
            // reqsBox
            // 
            reqsBox.BorderStyle = BorderStyle.None;
            reqsBox.ForeColor = Color.DarkGray;
            reqsBox.Location = new Point(228, 218);
            reqsBox.Name = "reqsBox";
            reqsBox.Size = new Size(332, 74);
            reqsBox.TabIndex = 9;
            reqsBox.Text = "Enter requirements...";
            reqsBox.Click += reqsBox_Click;
            reqsBox.TextChanged += reqsBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(240, 240, 168);
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label5.Location = new Point(222, 197);
            label5.Name = "label5";
            label5.Size = new Size(237, 20);
            label5.TabIndex = 8;
            label5.Text = "Requirements and Skills Required";
            // 
            // button1
            // 
            button1.Location = new Point(398, 298);
            button1.Name = "button1";
            button1.Size = new Size(164, 23);
            button1.TabIndex = 0;
            button1.Text = "Post Gig";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(228, 298);
            button2.Name = "button2";
            button2.Size = new Size(164, 23);
            button2.TabIndex = 1;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // gigTypeBox
            // 
            gigTypeBox.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gigTypeBox.FormattingEnabled = true;
            gigTypeBox.ImeMode = ImeMode.On;
            gigTypeBox.Items.AddRange(new object[] { "on_site", "remote", "flexible" });
            gigTypeBox.Location = new Point(404, 46);
            gigTypeBox.MaxDropDownItems = 3;
            gigTypeBox.Name = "gigTypeBox";
            gigTypeBox.Size = new Size(156, 24);
            gigTypeBox.TabIndex = 4;
            gigTypeBox.Text = "Gig Type";
            // 
            // endDateBox
            // 
            endDateBox.AutoSize = true;
            endDateBox.BackColor = Color.FromArgb(240, 240, 168);
            endDateBox.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            endDateBox.Location = new Point(16, 246);
            endDateBox.Name = "endDateBox";
            endDateBox.Size = new Size(71, 20);
            endDateBox.TabIndex = 6;
            endDateBox.Text = "End Date";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Location = new Point(15, 269);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DimGray;
            panel3.Location = new Point(90, 188);
            panel3.Name = "panel3";
            panel3.Size = new Size(470, 2);
            panel3.TabIndex = 5;
            // 
            // locationBox
            // 
            locationBox.BackColor = Color.FromArgb(240, 240, 168);
            locationBox.BorderStyle = BorderStyle.None;
            locationBox.Location = new Point(94, 170);
            locationBox.Name = "locationBox";
            locationBox.Size = new Size(466, 16);
            locationBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(240, 240, 168);
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label3.Location = new Point(15, 196);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 4;
            label3.Text = "Start Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(240, 240, 168);
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(15, 170);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 3;
            label2.Text = "Location:";
            // 
            // startDateBox
            // 
            startDateBox.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startDateBox.Location = new Point(15, 219);
            startDateBox.Name = "startDateBox";
            startDateBox.Size = new Size(200, 23);
            startDateBox.TabIndex = 5;
            // 
            // descriptionBox
            // 
            descriptionBox.BorderStyle = BorderStyle.None;
            descriptionBox.ForeColor = Color.DarkGray;
            descriptionBox.Location = new Point(18, 74);
            descriptionBox.Name = "descriptionBox";
            descriptionBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            descriptionBox.Size = new Size(541, 96);
            descriptionBox.TabIndex = 2;
            descriptionBox.Text = "Enter description...";
            descriptionBox.Click += descriptionBox_Click;
            descriptionBox.TextChanged += descriptionBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(240, 240, 168);
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label1.Location = new Point(10, 45);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 1;
            label1.Text = "Description";
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(titleBox);
            customPanel1.Controls.Add(label1);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.FromArgb(240, 240, 168);
            customPanel1.GradientTopColor = Color.FromArgb(240, 240, 168);
            customPanel1.Location = new Point(6, 3);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(564, 330);
            customPanel1.TabIndex = 12;
            // 
            // titleBox
            // 
            titleBox.BackColor = Color.FromArgb(240, 240, 168);
            titleBox.BorderStyle = BorderStyle.None;
            titleBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            titleBox.Location = new Point(13, 6);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(543, 36);
            titleBox.TabIndex = 0;
            titleBox.Text = "Title";
            // 
            // createGigForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "createGigForm";
            Size = new Size(570, 337);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private RichTextBox descriptionBox;
        private Label label1;
        private Label label2;
        private ComboBox gigTypeBox;
        private Button button2;
        private Button button1;
        private DateTimePicker dateTimePicker2;
        private Label endDateBox;
        private Label label3;
        private DateTimePicker startDateBox;
        private Panel panel3;
        private TextBox locationBox;
        private RichTextBox reqsBox;
        private Label label5;
        private TextBox rateBox;
        private Label label6;
        private CustomControls.CustomPanel customPanel1;
        private TextBox titleBox;
    }
}