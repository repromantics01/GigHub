using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigHubLibrary.Models
{
    public class GigModel
    {
        public int GigID { get; set; }
        public string GigTitle { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public GigType Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal? Rate { get; set; }
        public GigStatus Status { get; set; }
        public int gigPoster { get; set; }
        public DateTime DateCreated { get; set; }
        public string SkillsRequired { get; set; }
        public bool isSavedByUser { get; set; }

        public GigModel() { }

        public GigModel(string title, string desc, string loc, GigType type, DateTime sDate, DateTime eDate,
            decimal rate, GigStatus stat, DateTime dCreated, string skills)
        {
            GigTitle = title;
            Description = desc;
            Location = loc;
            Type = type;
            StartDate = sDate;
            EndDate = eDate;
            Rate = rate;
            Status = stat;
            DateCreated = dCreated;
            SkillsRequired = skills;
            isSavedByUser = false;

        }
    }
}
