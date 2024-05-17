using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using StartUpForm.UserControls;
using GigHubLibrary.Models;
using System.Runtime.CompilerServices;

namespace StartUpForm
{
    public partial class DasboardForm : Form
    {

        dashboardUC dbUC;
        searchUC sUC;
        UserModel model;
        public DasboardForm(UserModel model)
        {
            InitializeComponent();
            this.model = model;
            usersName.Text = model.FirstName + " " + model.LastName;
            dbUC = new dashboardUC(this.model);
            sUC = new searchUC(this.model);
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            DashboardMain.Controls.Clear();
            DashboardMain.Controls.Add(dbUC);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DashboardMain.Controls.Clear();
            DashboardMain.Controls.Add(sUC);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
