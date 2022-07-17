using AuthenticationWithCli.Database.Models;
using AuthenticationWithCli.Database.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationWithCli.ApplicationLogic.Validations
{
    internal class UserValidation
    {
        private static IEnumerable<User> Users;

        public static bool isValidFirstName(string firstName)
        {

            if (Validation.isLengthBetween(firstName, 3, 30))
            {
                return true;
            }
            Console.WriteLine("Daxil etdiyiniz ad yanlışdır, adın yalnız hərflərdən ibarət olduğuna, ilk hərfin böyük olduğuna və uzunluğunun 3 dən böyük, 30 - dan kiçik olduğuna əmin olun.");
            return false;



        }

        public static bool isValidLastName(string lastName)
        {
            if (Validation.isLengthBetween(lastName, 3, 30))
            {
                return true;
            }
            Console.WriteLine("Daxil etdiyiniz soyad yanlışdır, soyadın yalnız hərflərdən ibarət olduğuna, ilk hərfin böyük olduğuna və uzunluğunun 3 dən böyük, 30 - dan kiçik olduğuna əmin olun.");
            return false;
        }

        public static bool isValidEmail(string email)
        {
            if (Validation.Contains(email, '@'))
            {
                return true;
            }
            Console.WriteLine("Daxil etdiyiniz email yanlışdır, emaildə mütləq @ olmalıdır");
            return false;
        }

        public static bool isValidPassword(string password, string confirmPassword)
        {

            if (password == confirmPassword)
            {
                return true;
            }
            Console.WriteLine("Password is not match");
            return false;
        }



        public static bool isUserExists(string email)
        {
            if (!UserRepository.isUserExistsByEmail(email))
            {
                Console.WriteLine("User already exists");
                return true;

            }
            return false;
        }

        public static User isEmailAndPasswordCorrect(string email, string password)
        {
            foreach (User user in Users)
            {
                if (user.Email == email && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }

        public static bool isUserExistsByEmailAndPassword(string email, string password)
        {
            foreach (User user in Users)
            {
                if (user.Email == email && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
