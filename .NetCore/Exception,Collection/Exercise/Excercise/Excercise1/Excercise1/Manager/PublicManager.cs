using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Excercise1.Enums;
using Excercise1.Interface;
using Excercise1.Models;
using Excercise1.Repository;

namespace Excercise1.Manager
{
    public class PublicManager : IMenu
    {
        
            private IUserRepository userRepository;
            private IMenu menu;

            public PublicManager()
            {
                userRepository = new UserRepository();
            }

            public void DisplayMenu()
            {
                ShowMenu();
            }

            private void ShowMenu()
            {
                Console.WriteLine("\n===== MAIN MENU =====");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Register();
                        ShowMenu();
                        break;

                    case "2":
                        Login();
                        ShowMenu();
                        break;

                    case "3":
                        Console.WriteLine("Thank You!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        ShowMenu();
                        break;
                }
            }

            private void Register()
            {
                try
                {
                    Console.WriteLine("Enter First Name:");
                    string fname = Console.ReadLine();

                    Console.WriteLine("Enter Last Name:");
                    string lname = Console.ReadLine();

                    string email = GetEmail();

                    Console.WriteLine("Enter Phone:");
                    long phone = long.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Password:");
                    string password = Console.ReadLine();

                    // ✅ Always Customer
                    User user = new User(fname, lname, email, phone, password, Roles.Customer);

                    userRepository.Register(user);

                    Console.WriteLine("Registration Successful!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            private void Login()
            {
                try
                {
                    string email = GetEmail();

                    Console.WriteLine("Enter Password:");
                    string password = Console.ReadLine();

                    User user = userRepository.Login(email, password);

                    Console.WriteLine("Login Successful!");
                    Console.WriteLine("Welcome " + user.FirstName);

                    // ✅ Directly go to Customer Manager
                    menu = new CustomerManager(user);

                    menu.DisplayMenu();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            private string GetEmail()
            {
                Console.WriteLine("Enter Email:");
                string email = Console.ReadLine();

                Regex regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

                if (!regex.IsMatch(email))
                    throw new Exception("Invalid Email Format");

                return email;
            }
        }
    }


