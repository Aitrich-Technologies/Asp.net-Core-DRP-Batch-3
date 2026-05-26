using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WEH1.Enums;
using WEH1.Interface;
using WEH1.Repository;
using WEH1.Execptions;

namespace WEH1.Manager
{
    public class PublicManager:IMenu
    {

        IUserRepository repo = new UserRepository();
        IMenu menu;

        public void DisplayMenu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n1.Login\n2.Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        LoginAdmin();
                        break;

                    case "2":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }

        //private void LoginAdmin()
        //{
        //    Console.Write("Email: ");
        //    string email = Console.ReadLine();

        //    Console.Write("Password: ");
        //    string password = Console.ReadLine();

        //    var user = repo.Login(email, password);

        //    if (user != null && user.Role == Roles.Admin)
        //    {
        //        Console.WriteLine("\nLogin Successful!");
        //        Console.WriteLine("Welcome " + user.FirstName);

        //        menu = new AdminManager(user);
        //        menu.DisplayMenu();
        //    }
        //    else
        //    {
        //        Console.WriteLine("\n Login Failed! Invalid credentials.");
        //    }
        //}
        private void LoginAdmin()
        {
            try
            {
                string email = GetEmail();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(password))
                {
                    throw new InValidExceptions("Password cannot be empty.");
                }

                var user = repo.Login(email, password);

                if (user == null)
                {
                    throw new InValidExceptions("Invalid Email or Password.");
                }

                if (user.Role != Roles.Admin)
                {
                    throw new InValidExceptions("Access Denied! Admin Only.");
                }

                Console.WriteLine("\nLogin Successful!");
                Console.WriteLine("Welcome " + user.FirstName);

                menu = new AdminManager(user);
                menu.DisplayMenu();
            }

            catch (InValidExceptions ex)
            {
                Console.WriteLine("Input Error : " + ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("System Error : " + ex.Message);
            }

            finally
            {
                Console.WriteLine("Login Process Completed\n");
            }
        }

        private string GetEmail()
        {
            try
            {
                Console.Write("Email: ");
                string email = Console.ReadLine();

                Regex regex =
                new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

                if (!regex.IsMatch(email))
                {
                    throw new InValidExceptions
                    ("Please enter a valid email address.");
                }

                return email;
            }

            catch (InValidExceptions ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try again...\n");

                return GetEmail();
            }
        }
    }
}
