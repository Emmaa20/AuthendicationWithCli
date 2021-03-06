using System.Text;
using System.Threading.Tasks;

namespace AuthenticationWithCli.Database.Models
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string firstName, string lastName, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }

        public string GetUserInfo()
        {
            return $"Name : {FirstName}, Last name : {LastName} , Email :{Email}";
        }
    }
}
