using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Admin_Destination.Enums;
using Admin_Destination.Exceptions;
using Admin_Destination.Interface;
using Admin_Destination.Models;
using Admin_Destination.Repository;

namespace Admin_Destination.Manager
{
   public class PublicManager:IMenu
    {

        private TourManager tourManager;
        BookingManager bookingManager;
        IUserRepository repo = new UserRepository();
        CustomerManager customerManager;
        IMenu menu;
        int userCounter = 3;


        public PublicManager(
     TourManager manager,
     BookingManager booking)
        {
            tourManager = manager;
            bookingManager = booking;
        }

        public void DisplayMenu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n1.Register\n2.Login\n3.Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Register();
                        break;
                    case "2":
                        LoginAdmin();
                        break;
                    case "3":
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
                    throw new InvalidFormatException("Password cannot be empty.");
                }

                var user = repo.Login(email, password);

                if (user == null)
                {
                    throw new InvalidFormatException("Invalid Email or Password.");
                }

                if (user.Role == Roles.Customer)
                {
                    Console.WriteLine("\nLogin Successful!");
                    Console.WriteLine("Welcome " + user.FirstName);
                    customerManager = new CustomerManager(user,tourManager,bookingManager);
                    customerManager.DisplayMenu();
                    
                    
                }
                else if (user.Role == Roles.Admin)
                {
                    Console.WriteLine("\nLogin Successful!");
                    Console.WriteLine("Welcome " + user.FirstName);
                    menu = new AdminManager(user, tourManager);
                    menu.DisplayMenu();
                     
                }

            }

            catch (InvalidFormatException ex)
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
                    throw new InvalidFormatException
                    ("Please enter a valid email address.");
                }

                return email;
            }

            catch (InvalidFormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try again...\n");

                return GetEmail();
            }
        }

        public void Register()
        {

            try
            {
                User user = new User();

                Console.WriteLine("Enter first name : ");
                user.FirstName = Console.ReadLine();

                user.Email = GetEmail();

                Console.Write("Password: ");
                string password = Console.ReadLine();


                if (string.IsNullOrWhiteSpace(password))
                {
                    throw new InvalidFormatException("Password cannot be empty.");
                }

                Console.WriteLine("Enter phone number : ");
                user.Phone = Convert.ToDouble(Console.ReadLine());

                
                user.Id = userCounter++;
                user.Password = password;
                user.Role = Roles.Customer;
                repo.AddCustomer(user);

                Console.WriteLine("Registration Successful");
            }
            catch (InvalidFormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("System Error : " + ex.Message);
            }
        }
   }
}
