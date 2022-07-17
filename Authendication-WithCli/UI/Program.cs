using AuthenticationWithCli.ApplicationLogic;
using System;

namespace AuthenticationWithCli.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("/register");
            Console.WriteLine("/login");
            Console.WriteLine("/exit");
            //Console.WriteLine("/show-users");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Enter command:");
                string command = Console.ReadLine();
                if (command == "/register")
                {
                    Authendication.Register();
                }
                else if (command == "/login")
                {
                    Authendication.Login();
                }
                else if (command == "/exit")
                {
                    break;
                }
                //else if (command=="/show-users")
                //{
                //    Authendication.ShowUser();
                //}
                else
                {
                    Console.WriteLine("Command not found");
                }
            }
        }
    }
}