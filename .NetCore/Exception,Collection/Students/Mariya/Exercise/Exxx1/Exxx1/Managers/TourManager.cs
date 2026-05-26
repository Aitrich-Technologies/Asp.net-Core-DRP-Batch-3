using Exxx1.Interface;
using Exxx1.Models;
using Exxx1.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exxx1.Managers
{
    public class TourManager
    {

        private readonly ICustomerRepository customerRepository;
        private readonly ITourRepository tourRepository;

        private Customer loggedInCustomer;

        public TourManager()
        {
            customerRepository = new CustomerRepository();
            tourRepository = new TourRepository();
        }

        
        public void Register()
        {
            try
            {
                Console.WriteLine("\n===== CUSTOMER REGISTRATION =====");

                Console.Write("Enter Customer ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }

                Console.Write("Enter Email: ");
                string email = Console.ReadLine();

                Console.Write("Enter Password: ");
                string password = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(password))
                {
                    throw new ArgumentException("Password cannot be empty.");
                }

                Console.Write("Enter Phone Number: ");
                string phone = Console.ReadLine();

                if (!long.TryParse(phone, out _))
                {
                    throw new FormatException(
                        "Phone number should contain digits only."
                    );
                }

                Customer customer = new Customer()
                {
                    CustomerId = id,
                    Name = name,
                    Email = email,
                    Password = password,
                    Phone = phone
                };

                customerRepository.Register(customer);

                Console.WriteLine("Registration Successful!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

       
        public void Login()
        {
            try
            {
                Console.WriteLine("\n===== CUSTOMER LOGIN =====");

                Console.Write("Enter Email: ");
                string email = Console.ReadLine();

                Console.Write("Enter Password: ");
                string password = Console.ReadLine();

                loggedInCustomer =
                    customerRepository.Login(email, password);

                if (loggedInCustomer == null)
                {
                    throw new Exception("Invalid Email or Password.");
                }

                Console.WriteLine("Login Successful!");

                CustomerMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Login Error : " + ex.Message);
            }
        }

       
        public void CustomerMenu()
        {
            bool logout = false;

            while (!logout)
            {
                Console.WriteLine("\n===== CUSTOMER MENU =====");
                Console.WriteLine("1. View Tours");
                Console.WriteLine("2. View Profile");
                Console.WriteLine("3. Logout");

                Console.Write("Enter choice: ");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            ViewTours();
                            break;

                        case 2:
                            ViewProfile();
                            break;

                        case 3:
                            logout = true;
                            loggedInCustomer = null;
                            Console.WriteLine("Logged Out Successfully.");
                            break;

                        default:
                            throw new InvalidOperationException(
                                "Invalid Menu Choice."
                            );
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error : " + ex.Message);
                }
            }
        }

        
        public void ViewTours()
        {
            var tours = tourRepository.GetAllTours();

            Console.WriteLine("\n===== AVAILABLE TOURS =====");

            foreach (var tour in tours)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Tour ID      : " + tour.TourId);
                Console.WriteLine("Tour Name    : " + tour.TourName);
                Console.WriteLine("Destination  : " + tour.Destination);
                Console.WriteLine("Price        : " + tour.Price);
                Console.WriteLine("Duration     : " + tour.DurationDays + " Days");
            }
        }

  
        public void ViewProfile()
        {
            Console.WriteLine("\n===== CUSTOMER PROFILE =====");

            Console.WriteLine("Customer ID : " + loggedInCustomer.CustomerId);
            Console.WriteLine("Name        : " + loggedInCustomer.Name);
            Console.WriteLine("Email       : " + loggedInCustomer.Email);
            Console.WriteLine("Phone       : " + loggedInCustomer.Phone);
        }
    }
}
