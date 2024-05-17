using GigHubLibrary;
using GigHubLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartUpForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private bool ValidateForm()
        {
            bool Output = true;

            if (addUserName.Text.Length == 0 || addUserName.Text.Length < 8)
            {
                Output = false;
                usernameErrorLabel.Visible = true;
            }
            // TODO - Else if username text exists in the database, username cannot be validated

            if (Password.Text.Length == 0)
            {
                Output = false;
                shortPasswordErrorLabel.ForeColor = Color.Red;
                shortPasswordErrorLabel.Text = "Required.Field";
            }
            else if (Password.Text.Length < 8)
            {
                Output = false;
                shortPasswordErrorLabel.Visible = true;
            }
            if (Password.Text != Password2.Text)
            {
                Output = false;
                PasswordsMatchntErrorLabel.Visible = true;
            }
            if (firstName.Text.Length == 0 || lastName.Text.Length == 0)
            {
                Output = false;
                firstNameErrorLabel.Visible = true;
            }
            if (emailAddress.Text.Length == 0)
            {
                Output = false;
                lastNameErrorLabel.Visible = true;
            }
            else if (!emailAddress.Text.EndsWith("@vsu.edu.ph"))
            {
                Output = false;
                emailAddressErrorLabel.Visible = true;
            }

            return Output;
        }

        private void addUserName_TextChanged(object sender, EventArgs e)
        {
            addUserName.ForeColor = Color.Black;
            if (addUserName.Text.Length == 1 || addUserName.Text.Length < 8)
            {
                usernameErrorLabel.Visible = true;
                usernameErrorLabel.ForeColor = Color.DarkGray;
                usernameErrorLabel.Text = "Username must be at least 8 characters long.";
            }
            else { usernameErrorLabel.Text = ""; }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            Password.ForeColor = Color.Black;
            if (Password.Text.Length == 1 || Password.Text.Length < 8)
            {
                Password.PasswordChar = '●';
                shortPasswordErrorLabel.Visible = true;
                shortPasswordErrorLabel.ForeColor = Color.DarkGray;
                shortPasswordErrorLabel.Text = "Password too short.";
            }
            else { shortPasswordErrorLabel.Text = ""; }
        }

        private void Password2_TextChanged(object sender, EventArgs e)
        {
            Password2.ForeColor = Color.Black;
            if (Password.Text != Password2.Text)
            {
                Password2.PasswordChar = '●';
                PasswordsMatchntErrorLabel.Visible = true;
                PasswordsMatchntErrorLabel.Text = "Passwords do not match.";
            }
            else { PasswordsMatchntErrorLabel.Text = ""; }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (addUserName.Text == "Username")
            {
                usernameErrorLabel.Visible = true;
                usernameErrorLabel.ForeColor = Color.Red;
                usernameErrorLabel.Text = "Required Field.";
            }

            if (Password.Text == "Enter Password")
            {
                shortPasswordErrorLabel.Visible = true;
                shortPasswordErrorLabel.ForeColor = Color.Red;
                shortPasswordErrorLabel.Text = "Required Field.";
            }

            if (firstName.Text == "")
            {
                firstNameErrorLabel.Visible = true;
                firstNameErrorLabel.Text = "Required Field.";
            }

            if (lastName.Text == "")
            {
                lastNameErrorLabel.Visible = true;
                lastNameErrorLabel.Text = "Required Field.";
            }

            if (emailAddress.Text == "")
            {
                emailAddressErrorLabel.Visible = true;
                emailAddressErrorLabel.Text = "Required Field.";
            }
            else if (!emailAddress.Text.EndsWith("@vsu.edu.ph"))
            {
                emailAddressErrorLabel.Visible = true;
                emailAddressErrorLabel.Text = "Your VSU email address is required.";
            }

            if (ShadeStudentButton.Checked == false && ShadeFacultyButton.Checked == false)
            {
                RadioErrorLabel.Visible = true;
                RadioErrorLabel.Text = "Select user type.";
            }

            if (ValidateForm())
            {
                UserModel model = new UserModel(firstName.Text,
                                                lastName.Text,
                                                addUserName.Text,
                                                emailAddress.Text,
                                                Password.Text,
                                                "", "",
                                                GetSelectedUserType(),
                                                DateTime.UtcNow);

                UserModel savedUser = GlobalConfig.Connection.CreateUser(model);
                
                if(savedUser != null)
                {
                    if(savedUser.UserType == UserType.faculty)
                    {
                        Dashboard_Faculty dbFaculty = new Dashboard_Faculty(savedUser);
                        dbFaculty.Show();
                        this.Hide();
                    }
                    else
                    {
                        DasboardForm dbStudent = new DasboardForm(savedUser);
                        dbStudent.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Failed to create user. Please try again.");
                }

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Password.PasswordChar = '\0';
                Password2.PasswordChar = '\0';
            }
            else
            {
                Password.PasswordChar = '●';
                Password2.PasswordChar = '●';
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            addUserName.ForeColor = Color.DarkGray;
            addUserName.Text = "Username";

            Password.ForeColor = Color.DarkGray;
            Password.Text = "Enter Password";

            Password2.ForeColor = Color.DarkGray;
            Password2.Text = "Confirm Password";

            firstName.Text = "";
            lastName.Text = "";
            emailAddress.Text = "";
            usernameErrorLabel.Visible = false;
            shortPasswordErrorLabel.Visible = false;
            PasswordsMatchntErrorLabel.Visible = false;
            firstNameErrorLabel.Visible = false;
            lastNameErrorLabel.Visible = false;
            emailAddressErrorLabel.Visible = false;
            checkBox1.Checked = false;

            ShadeFacultyButton.Checked = false;
            ShadeStudentButton.Checked = false;
            RadioErrorLabel.Visible = false;
        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {
            if (firstName.Text.Length > 0) { firstNameErrorLabel.Visible = false; }
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {
            if (lastName.Text.Length > 0) { lastNameErrorLabel.Visible = false; }
        }

        private void emailAddress_TextChanged(object sender, EventArgs e)
        {
            if (emailAddress.Text.Length > 0) { emailAddressErrorLabel.Visible = false; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private UserType GetSelectedUserType()
        {
            RadioErrorLabel.Visible = false;
            UserType type = new UserType();
            if (ShadeStudentButton.Checked == true)
                type = UserType.student;
            else if (ShadeFacultyButton.Checked == true)
                type = UserType.faculty;

            return type;

        }

        private void ShadeFacultyButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioErrorLabel.Visible = false;
        }

        private void ShadeStudentButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioErrorLabel.Visible = false;
        }
    }
}
