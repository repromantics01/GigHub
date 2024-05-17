using GigHubLibrary;
using GigHubLibrary.Models;
using StartUpForm.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartUpForm.CustomControls
{
    public partial class GigCustomList : UserControl
    {
        GigModel model;
        UserModel user;

        public GigCustomList(GigModel model)
        {
            InitializeComponent();
            this.user = GlobalConfig.Connection.GetUserById(model.gigPoster);
            this.model = model;
            this.gigTitleLabel.Text = model.GigTitle;
            DateOnly dateOnly = DateOnly.FromDateTime(model.DateCreated);
            this.dateLabel.Text = "Posted: " + dateOnly.ToString() + ",";

            string str = model.Type.ToString();
            string capitalizedString = str.ToUpper()[0] + str.Substring(1);
            this.typeLabel.Text = (model.Type == GigType.on_site) ? "On-site" : capitalizedString;
            this.descriptionTextBox.Text = model.Description;

            if (user.UserType == UserType.faculty)
                this.button1.Text = "Edit Details";
        }

        public GigCustomList(GigModel model, UserModel studentUser)
        {
            InitializeComponent();
            this.user = studentUser;

            this.model = model;
            this.gigTitleLabel.Text = model.GigTitle;
            DateOnly dateOnly = DateOnly.FromDateTime(model.DateCreated);
            this.dateLabel.Text = "Posted: " + dateOnly.ToString() + ",";

            string str = model.Type.ToString();
            string capitalizedString = str.ToUpper()[0] + str.Substring(1);
            this.typeLabel.Text = (model.Type == GigType.on_site) ? "On-site" : capitalizedString;
            this.descriptionTextBox.Text = model.Description;

            if (user.UserType == UserType.student)
                this.button1.Text = "View Details";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user.UserType == UserType.faculty)
            {
                GigFullDetails fD = new GigFullDetails(this.model);
                fD.Show();
            }
            else
            {
                GigFullDetails_Student fDS = new GigFullDetails_Student(this.model, this.user);
                fDS.Show();
            }

        }
    }
}
