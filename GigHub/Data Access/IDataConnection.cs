using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using GigHubLibrary.Models;

namespace GigHubLibrary
{
    public interface IDataConnection
    {
        UserModel CreateUser(UserModel model);
        GigModel CreateGig(GigModel model);
        UserModel GetUserById(int userId);
        List<GigModel> GetGigsPostedByID(int userId);
        List<GigModel> GetGigsInDatabase();
        bool UpdatesGig(GigModel gig);
        bool DeletesGig(int gigId);
        bool UpdatesUser(UserModel user);
        List<GigModel> GetSavedGigs(int userId);
        bool SaveGig(int gigId, int userId);
        bool UnsaveGig(int gigId, int userId);

    }
}
