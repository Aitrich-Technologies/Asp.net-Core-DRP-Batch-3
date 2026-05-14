using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Excercise3.Enums;
using Excercise3.Exceptions;
using Excercise3.Interface;
using Excercise3.Models;
using Excercise3.Repository;

namespace Excercise3.Manager
{
    public class PublicManager : IMenu
    {
      
        UserRepository userRepository = new UserRepository();

        // ✅ create ONE shared instance
        private ITourProvider tourRepo = new TourManager();

        private IBookingRepository bookingRepo = new BookingRepository();

        public User LoggedUser = new User();
        bool _isLogged = false;
        IMenu menu;
        public void DisplayMenu()
        {
            ShowMainMenu();
        }

        private void ShowMainMenu()
        {
            bool exitProgram = false;

            while (!exitProgram)
            {
                Console.WriteLine("\n----- PUBLIC MENU -----");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register (Customer Only)");
                Console.WriteLine("3. Exit");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        LoginUser();
                        if (_isLogged)
                            menu.DisplayMenu();
                        break;

                    case "2":
                        RegisterCustomer();
                        break;

                    case "3":
                        exitProgram = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }

        private void LoginUser()
        {
            try
            {
                string email = GetEmail();

                Console.WriteLine("Please enter password:");
                string password = Console.ReadLine();

                LoggedUser = userRepository.Login(email, password);

                if (LoggedUser != null)
                {
                    Console.WriteLine("Login Successful!!");
                    Console.WriteLine("Welcome " + LoggedUser.FirstName);

                    _isLogged = true;
                    if (LoggedUser.Role == Roles.Agent)
                        menu = new AgentManager(LoggedUser, userRepository, tourRepo);

                    else if (LoggedUser.Role == Roles.Customer)
                        menu = new CustomerManager(LoggedUser, tourRepo, bookingRepo);

                    else
                        Console.WriteLine("Invalid Role");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void RegisterCustomer()
        {
            try
            {
                Console.WriteLine("\n----- CUSTOMER REGISTRATION -----");

                Console.Write("First Name: ");
                string firstName = Console.ReadLine();

                Console.Write("Last Name: ");
                string lastName = Console.ReadLine();

                string email = GetEmail();

                long phone = GetPhoneNumber();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                User newUser = new User(firstName,lastName,email,phone,password,Roles.Customer);

                userRepository.Register(newUser);

                Console.WriteLine("Registration Successful! You can now login.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private string GetEmail()
        {
            try
            {
                Console.WriteLine("Please enter your Email:");
                string email = Console.ReadLine();

                Regex regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

                if (!regex.IsMatch(email))
                    throw new InvalidFormatException("Please enter a valid Email");

                return email;
            }
            catch (InvalidFormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try Again...");
                return GetEmail();
            }
        }

        private long GetPhoneNumber()
        {
            try
            {
                Console.WriteLine("Enter Phone Number:");
                long phone = long.Parse(Console.ReadLine());
                return phone;
            }
            catch
            {
                Console.WriteLine("Invalid phone number. Try again.");
                return GetPhoneNumber();
            }
        }
    }
}

