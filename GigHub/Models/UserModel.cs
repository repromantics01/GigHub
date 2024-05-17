using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace GigHubLibrary.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string? MessengerLink { get; set; }
        public string? PhoneNumber { get; set; }
        public UserType UserType { get; set; }
        public DateTime DateCreated { get; set; }

        public UserModel() { }

        public UserModel(string firstName, string lastName, string username, string email, string password,
            string messengerLink, string pN, UserType type, DateTime dCreated)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            EmailAddress = email;
            Password = password;
            MessengerLink = messengerLink;
            PhoneNumber = pN;
            UserType = type;
            DateCreated = dCreated;
        }
    }
}
