using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using StartUpForm.UserControls;
using GigHubLibrary.Models;

namespace StartUpForm
{
    public partial class dashboardUC : UserControl
    {
        editProfile eP;
        savedGigUCFINAL sG;
        UserModel model;
        public dashboardUC(UserModel model)
        {
            InitializeComponent();
            this.model = model;
            eP = new editProfile(this.model);
            sG = new savedGigUCFINAL(this.model);
        }

        private void rjButton2_Click_1(object sender, EventArgs e)
        {
            dashboardMainPanel.Controls.Clear();
            dashboardMainPanel.Controls.Add(eP);
            eP.Dock = DockStyle.Fill;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            dashboardMainPanel.Controls.Clear();
            dashboardMainPanel.Controls.Add(sG);
            eP.Dock = DockStyle.Fill;
        }

        private void rjButton1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(216, 216, 151);
        }

        private void rjButton1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(240, 240, 168);
        }

        private void rjButton2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(216, 216, 151);
        }

        private void rjButton2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(240, 240, 168);
        }
    }
}
