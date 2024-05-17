using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GigHubLibrary;
using GigHubLibrary.Models;
using Microsoft.VisualBasic.ApplicationServices;
using StartUpForm.UserControls;

namespace StartUpForm
{
    public partial class createGigForm : UserControl
    {
        private int userId;

        public createGigForm(int userId)
        {
            this.userId = userId;
            InitializeComponent();
        }

        private bool ValidateForm()
        {
            bool output = true;
            if (titleBox.Text == "Title" || titleBox.Text == "")
            {
                output = false;
            }
            if (descriptionBox.Text == "Enter description..." || descriptionBox.Text == "")
            {
                output = false;
            }
            if (locationBox.Text.Length == 0)
            {
                output = false;
            }

            if (rateBox.Text.Length == 0)
            {
                output = false;
            }

            if (reqsBox.Text.Length == 0 || reqsBox.Text == "Enter requirements...")
            {
                output = false;
            }

            return output;

        }

        private void gigTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void titleBox_TextChanged(object sender, EventArgs e)
        {
            titleBox.ForeColor = Color.Black;
        }

        private void descriptionBox_TextChanged(object sender, EventArgs e)
        {
            descriptionBox.ForeColor = Color.Black;
        }

        private void reqsBox_TextChanged(object sender, EventArgs e)
        {
            reqsBox.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                
                decimal rate = decimal.Parse(rateBox.Text);
                string selectedType = (string)gigTypeBox.SelectedItem;
                GigType enumGigType = (GigType)Enum.Parse(typeof(GigType), selectedType, true);

                GigModel model = new GigModel(titleBox.Text,
                                              descriptionBox.Text,
                                              locationBox.Text,
                                              enumGigType,
                                              startDateBox.Value,
                                              dateTimePicker2.Value,
                                              rate,
                                              GigStatus.open,
                                              DateTime.Now,
                                              reqsBox.Text);

                model.gigPoster = userId;
                GigModel newGig = GlobalConfig.Connection.CreateGig(model);

                if (newGig != null)
                {
                  
                        MessageBox.Show("Gig created successfully!");
                        titleBox.Text = "Title";
                        descriptionBox.Text = "Enter description...";
                        locationBox.Text = "";
                        gigTypeBox.Text = "Gig Type";
                        startDateBox.Value = DateTime.Now;
                        dateTimePicker2.Value = DateTime.Now;
                        rateBox.Text = "0.00";
                        reqsBox.Text = "Enter Requirements...";

                }
                else
                {
                    MessageBox.Show("Failed to create gig. Please try again.");
                }

            }
            else
                MessageBox.Show("Some required fields are missing. Please Try again.");
        }

        private void titleBox_Click(object sender, EventArgs e)
        {
            if (titleBox.Text == "Title")
                titleBox.Text = "";
        }

        private void descriptionBox_Click(object sender, EventArgs e)
        {
            if (descriptionBox.Text == "Enter description...")
                descriptionBox.Text = "";
        }

        private void reqsBox_Click(object sender, EventArgs e)
        {
            if (reqsBox.Text == "Enter requirements...")
                reqsBox.Text = "";
        }


    }
}
