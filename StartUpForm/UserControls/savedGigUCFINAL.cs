using GigHubLibrary.Models;
using StartUpForm.CustomControls;
using GigHubLibrary;
using System.Windows.Forms;


namespace StartUpForm.UserControls
{
    public partial class savedGigUCFINAL : UserControl
    {
        UserModel model;
        public List<GigModel> postedGigs;

        public savedGigUCFINAL(UserModel model)
        {
            InitializeComponent();
            this.model = model;
           
            if (this.model.UserType == UserType.faculty)
            {
                label4.Text = "Your Posted Gigs";
                postedGigs = GlobalConfig.Connection.GetGigsPostedByID(model.Id);
            }
            else
            {
                label4.Text = "Your Saved Gigs";
                postedGigs = GlobalConfig.Connection.GetSavedGigs(model.Id);
            }

            
        }
        private void savedGigUCFINAL_Load(object sender, EventArgs e)
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
                    GigCustomList Thumbnail = new GigCustomList(gigModel,model);
                    Thumbnail.button1.Text = "View Details";
                    flowLayoutPanel.Controls.Add(Thumbnail);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

    }
}
