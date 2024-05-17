using GigHubLibrary;
using GigHubLibrary.Models;
using StartUpForm.CustomControls;
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

namespace StartUpForm.UserControls
{
    public partial class searchUC : UserControl
    {
        List<GigModel> postedGigs;
        UserModel student; //current student user
        public searchUC(UserModel model)
        {
            InitializeComponent();
            this.student = model;
            postedGigs = GlobalConfig.Connection.GetGigsInDatabase();
        }

        private void searchUC_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        public void populateItems()
        {
            List<GigCustomList> list = new List<GigCustomList>();

            try
            {
                foreach (GigModel gigModel in postedGigs)
                {
                    GigCustomList Thumbnail = new GigCustomList(gigModel, student);
                    Thumbnail.button1.Text = "View Details";

                    flowLayoutPanel1.Controls.Add(Thumbnail);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void populateItemsWithSearch()
        {
            List<GigCustomList> list = new List<GigCustomList>();
            string searchTerm = searchTextBox.Text.ToLower();

            try
            {
                foreach (GigModel gigModel in postedGigs)
                {
                    if (gigModel.GigTitle.ToLower().Contains(searchTerm) ||
                      gigModel.Description.ToLower().Contains(searchTerm) ||
                      gigModel.SkillsRequired.ToLower().Contains(searchTerm))
                    {
                        GigCustomList Thumbnail = new GigCustomList(gigModel, student);
                        Thumbnail.button1.Text = "View Details";
                        flowLayoutPanel1.Controls.Add(Thumbnail);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            populateItemsWithSearch();
        }
    }
}
