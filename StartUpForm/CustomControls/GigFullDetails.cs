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
using System.Drawing;
using GigHubLibrary;
using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection;
using StartUpForm.UserControls;

namespace StartUpForm.CustomControls
{
    public partial class GigFullDetails : Form
    {
        GigModel gig;
        UserModel user;

        public delegate void GigUpdatedEventHandler(GigModel updatedGig);
        public event GigUpdatedEventHandler GigUpdated;
        public GigFullDetails(GigModel model)
        {
            InitializeComponent();
            this.gig = model;
            this.gigTitleLabel.Text = gig.GigTitle;
            this.descriptionTextBox.Text = model.Description;
            this.locationLabel.Text = model.Location;

            user = GlobalConfig.Connection.GetUserById(gig.gigPoster);
            this.startDate.Value = gig.StartDate;
            this.endDate.Value = gig.EndDate;
            this.reqsLabel.Text = gig.SkillsRequired;
            this.rateLabel.Text = gig.Rate.ToString();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this gig?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                bool success = GlobalConfig.Connection.DeletesGig(gig.GigID);

                if (success)
                {
                    MessageBox.Show("Gig deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    //TODO - Refresh the form so it displays the updated list
                }
                else
                {
                    MessageBox.Show("Failed to delete gig. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void rjButton4_Click(object sender, EventArgs e)
        {
            if (gig.Status == GigStatus.open)
            {
                rjButton4.Text = "Mark as Open";
                this.gig.Status = GigStatus.closed;
            }
            else
            {
                rjButton4.Text = "Mark as Close";
                this.gig.Status = GigStatus.open;
            }

        }

        private void doneButton_Click_1(object sender, EventArgs e)
        {
            if (this.gig.Description != this.descriptionTextBox.Text ||
                this.gigTitleLabel.Text != gig.GigTitle ||
                this.locationLabel.Text != gig.Location ||
                this.startDate.Value != gig.StartDate ||
                this.endDate.Value != gig.EndDate ||
                this.reqsLabel.Text != gig.SkillsRequired ||
                this.rateLabel.Text != gig.Rate.ToString())
            {
                this.gig.Description = this.descriptionTextBox.Text;
                this.gig.GigTitle = this.gigTitleLabel.Text;
                this.gig.Location = this.locationLabel.Text;
                this.gig.StartDate = this.startDate.Value;
                this.gig.EndDate = this.endDate.Value;
                this.gig.SkillsRequired = this.reqsLabel.Text;
                this.gig.Rate = Decimal.Parse(this.rateLabel.Text);

                bool success = GlobalConfig.Connection.UpdatesGig(this.gig);

                if (success)
                {
                    MessageBox.Show("Gig details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update gig details. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No changes detected. Click 'Cancel' to close.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

    }
}
