using GigHubLibrary;
using GigHubLibrary.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartUpForm.UserControls
{
    public partial class editProfile : UserControl
    {
        UserModel model;
        public editProfile(UserModel model)
        {
            InitializeComponent();
            this.model = GlobalConfig.Connection.GetUserById(model.Id);
            textBox1.Text = model.FirstName;
            lastNameTextbox.Text = model.LastName;
            textBox3.Text = model.Username;
            textBox4.Text = model.EmailAddress;
            textBox5.PasswordChar = '*';
            textBox5.Text = model.Password;
            textBox6.Text = model.PhoneNumber;
            textBox7.Text = model.MessengerLink;
            FullNameLabel.Text = model.FirstName + " " + model.LastName;
            usernameLabel.Text = model.UserType.ToString().ToUpper();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    profileImg.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "Add")
            {
                textBox6.Text = "";
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != model.FirstName ||
                this.lastNameTextbox.Text != model.LastName ||
                this.textBox3.Text != model.Username ||
                this.textBox4.Text != model.EmailAddress ||
                this.textBox5.Text != model.Password ||
                this.textBox6.Text != model.PhoneNumber ||
                this.textBox7.Text != model.MessengerLink)
            {
                this.model.FirstName = this.textBox1.Text;
                this.model.LastName = this.lastNameTextbox.Text;
                this.model.Username = this.textBox3.Text;
                this.model.EmailAddress = this.textBox4.Text;
                this.model.Password = this.textBox5.Text;
                this.model.PhoneNumber = this.textBox6.Text;
                this.model.MessengerLink = this.textBox7.Text;


                bool success = GlobalConfig.Connection.UpdatesUser(this.model);

                if (success)
                {
                    MessageBox.Show("User details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dashboard_Faculty refresh = new Dashboard_Faculty(model);
                    editProfile eP = new editProfile(model);
                    refresh.Show();
                }
            }
            else
            {
                MessageBox.Show("No changes detected. Click 'Cancel' to close.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            


        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = model.FirstName;
            this.lastNameTextbox.Text = model.LastName;
            this.textBox3.Text = model.Username;
            this.textBox4.Text = model.EmailAddress;
            this.textBox5.Text = model.Password;
            this.textBox6.Text = model.PhoneNumber;
            this.textBox7.Text = model.MessengerLink;
        }
    }
}
