using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigHubLibrary.Models
{
    public class UserContext
    {
        private int _userID;
        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        public static UserContext Current { get; private set; }

        public static void SetCurrentUser(int userID)
        {
            Current = new UserContext { UserID = userID };
        }
    }
}
