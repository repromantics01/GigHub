using GigHubLibrary;
using GigHubLibrary.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartUpForm.UserControls
{
    public partial class GigFullDetails_Student : Form
    {
        GigModel gig;
        UserModel currentUser;
        int gigCreatorID;


        public GigFullDetails_Student(GigModel gig, UserModel user)
        {
            InitializeComponent();
            this.gig = gig;
            this.currentUser = user;
            UserModel creator = GlobalConfig.Connection.GetUserById(gig.gigPoster);
            nameOfCreatorLabel.Text = creator.FirstName + " " + creator.LastName;

            datePostedLabel.Text = (DateOnly.FromDateTime(gig.DateCreated)).ToString("MMMM d, yyyy");
            typeLabel.Text = gig.Type.ToString();
            statusLabel.Text = gig.Status.ToString();
            rateLabel.Text = gig.Rate.ToString();
            locationLabel.Text = gig.Location;
            emailLabel.Text = creator.EmailAddress;
            descriptionTextBox.Text = gig.Description;
            gigTitleLabel.Text = gig.GigTitle;

            //PLACEIT HERE
            if (IsGigSavedByUser(gig.GigID, currentUser.Id))
            {
                this.rjButton3.Text = "Unsave Gig";
                rjButton3.BackColor = Color.Gray;
            }
            else
            {
                this.rjButton3.Text = "Save Gig";
                rjButton3.BackColor = Color.FromArgb(115, 138, 81);
            }

            if (creator.PhoneNumber == null)
                label8.Text = "";
            label8.Text = creator.PhoneNumber;

            if (creator.MessengerLink == null)
                label8.Text = "";
            messengerLinkLabel.Text = creator.MessengerLink;

            reqsLabel.Text = gig.SkillsRequired;

            this.startDateLabel.Text = (DateOnly.FromDateTime(gig.StartDate)).ToString("MMMM d, yyyy");
            this.endDateLabel.Text = (DateOnly.FromDateTime(gig.EndDate)).ToString("MMMM d, yyyy");
            
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {

            if (this.rjButton3.Text == "Save Gig")
            {
                this.rjButton3.Text = "Unsave Gig";
                this.gig.isSavedByUser = true;
                rjButton3.BackColor = Color.Gray;
            }
            else
            {
                this.rjButton3.Text = "Save Gig";
                rjButton3.BackColor = Color.FromArgb(115, 138, 81);
                this.gig.isSavedByUser = false;
            }
            
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            int gigId = gig.GigID;
            int userId = currentUser.Id;

            if (gig.isSavedByUser)
            {
                GlobalConfig.Connection.SaveGig(gigId, userId);
            }
            else GlobalConfig.Connection.UnsaveGig(gigId, userId);
            this.Hide();
        }

        public bool IsGigSavedByUser(int gigId, int userId)
        {
            var connection = new SqlConnection(@"Data Source=DESKTOP-R83M1NS;Initial Catalog=GigHub;Integrated Security=True");
            connection.Open();

            // Prepare and execute the query
            string query = "SELECT COUNT(*) FROM SavedGigs WHERE GigId = '"+gigId +"' AND UserId = '"+userId+"'";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@gigId", gigId);
            cmd.Parameters.AddWithValue("@userId", userId);

            int count = (int)cmd.ExecuteScalar(); // Get the number of rows returned

            connection.Close();

            return count > 0; 
        }

    }
}
