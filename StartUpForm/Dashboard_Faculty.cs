using GigHubLibrary;
using GigHubLibrary.Models;
using StartUpForm.UserControls;
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
    public partial class Dashboard_Faculty : Form
    {
        UserModel model;
        createGigForm cG;
        savedGigUCFINAL sG;
        editProfile eP;

        public Dashboard_Faculty(UserModel model)
        {
            InitializeComponent();
            this.model = model;
            usersName.Text = this.model.FirstName + " " + this.model.LastName;
            label1.Text = this.model.Username;
           

            List<GigModel> userGigs = GlobalConfig.Connection.GetGigsPostedByID(model.Id);
            this.cG = new createGigForm(this.model.Id);
            this.sG = new savedGigUCFINAL(this.model);
            this.eP = new editProfile(this.model);
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(sG);
                    
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(cG);
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(eP);
        }
    }
}
