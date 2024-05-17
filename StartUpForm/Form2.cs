using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GigHubLibrary;
using GigHubLibrary.Models;
using System.Reflection;

namespace StartUpForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-R83M1NS;Initial Catalog=GigHub;Integrated Security=True");

        private bool ValidateForm()
        {
            bool output = true;

            if (userName.Text.Length == 0)
            {
                output = false;
                emptyUsernamErrorLabel.Visible = true;
                emptyUsernamErrorLabel.Text = "Required Field.";
            }

            if (password.Text.Length == 0)
            {
                output = false;
                emptyPasswordErrorLabel.Visible = true;
                emptyPasswordErrorLabel.Text = "Required Field.";
            }
            return output;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userName.Text == "")
            {
                emptyUsernamErrorLabel.Visible = true;
                emptyUsernamErrorLabel.Text = "Required Field.";
            }

            if (password.Text == "")
            {
                emptyPasswordErrorLabel.Visible = true;
                emptyPasswordErrorLabel.Text = "Required Field.";
            }

            if (ValidateForm())
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-R83M1NS;Initial Catalog=GigHub;Integrated Security=True");
                conn.Open();
                /*String username, user_password;
                username = userName.Text;
                user_password = password.Text;*/

                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM dbo.Users WHERE username ='" + userName.Text+"' AND password = '"+password.Text+"'", conn);
                    string query = "SELECT id FROM dbo.Users WHERE username ='" + userName.Text + "' AND password = '" + password.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int userId = Convert.ToInt32(cmd.ExecuteScalar());

                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if(dt.Rows.Count>0)
                    {
                        UserModel loggedUser = GlobalConfig.Connection.GetUserById(userId);

                        if(loggedUser.UserType == UserType.student)
                        {
                            DasboardForm dashboard = new DasboardForm(loggedUser);
                            dashboard.Show();
                        }
                        else
                        {
                            Dashboard_Faculty dashboard = new Dashboard_Faculty(loggedUser);
                            dashboard.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid log-in credentials.Try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error." + ex.Message);
                }
                finally
                { 
                    conn.Close();
                }
            }
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {
            userName.ForeColor = Color.Black;
            emptyUsernamErrorLabel.Visible = true;
            if (userName.Text.Length > 0)
                emptyUsernamErrorLabel.Text = "";
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.ForeColor = Color.Black;
            emptyPasswordErrorLabel.Visible = true;
            if (password.Text.Length > 0)
                password.PasswordChar = '●';

            emptyPasswordErrorLabel.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            Close();
        }
    }
}
