using AuthenticationWithCli.Database.Models;
using AuthenticationWithCli.Database.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationWithCli.ApplicationLogic.Validations;

namespace AuthenticationWithCli.ApplicationLogic
{
    internal class Authendication
    {
        public static void Register()
        {
            Console.Write("Please enter user's name:");
            string firstName = Console.ReadLine();

            Console.Write("Please enter user's last name:");
            string lastName = Console.ReadLine();

            Console.Write("Pleace enter user's email address:");
            string email = Console.ReadLine();

            Console.Write("Pleace enter user's password:");
            string password = Console.ReadLine();

            Console.Write("Pleace enter user's confirm password:");
            string confirmPassword = Console.ReadLine();

            if (
               UserValidation.isValidFirstName(firstName) &
               UserValidation.isValidLastName(lastName) &
               UserValidation.isValidEmail(email) &
               UserValidation.isValidPassword(password, confirmPassword) &
               !UserValidation.isUserExists(email)
              )
            {
                User user = UserRepository.AddUser(firstName, lastName, email, password);
                Console.WriteLine($"User added to system,his/her details are: {user.GetUserInfo()}");
            }
        }
        public static void Login()
        {
            Console.Write("Please enter user's email:");
            string email = Console.ReadLine();

            Console.Write("Please enter user's password:");
            string password = Console.ReadLine();

            //if (Validation.isUserExistsByEmailAndPassword(email, password))
            //{
            //    User user = UserRepository.GetUserByEmail(email);
            //}
        }




    }
}


