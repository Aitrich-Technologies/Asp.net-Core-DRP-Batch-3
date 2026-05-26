using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin_Destination.Interface;
using Admin_Destination.Models;
using Admin_Destination.Repository;

namespace Admin_Destination.Manager
{
    public class AdminManager : IMenu
    {
        private User loggedUser;
        private UserRepository userRepo = new UserRepository();
        private ITourService tourService;
        private Lists display = new Lists();

        public AdminManager(User user, ITourService service)
        {
            loggedUser = user;
            tourService = service;
        }

        public void DisplayMenu()
        {
            bool logout = false;

            while (!logout)
            {
                Console.WriteLine("\n1.List All Admins");
                Console.WriteLine("2.My Profile");
                Console.WriteLine("3.Add Tour Destination");
                Console.WriteLine("4.List Tour Destinations");
                Console.WriteLine("5.Logout");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        display.PrintAdmins(userRepo.GetAllAdmins());
                        break;

                    case "2":
                        MyProfile();
                        break;

                    case "3":
                        AddTour();
                        break;

                    case "4":
                        display.PrintTours(tourService.GetTours());
                        break;

                    case "5":
                        Console.WriteLine("Logged out successfully.");
                        logout = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        private void MyProfile()
        {
            Console.WriteLine("\n--- My Profile ---");
            Console.WriteLine($"Id    : {loggedUser.Id}");
            Console.WriteLine($"Name  : {loggedUser.FirstName}");
            Console.WriteLine($"Email : {loggedUser.Email}");
        }

        private void AddTour()
        {
            Console.Write("Destination: ");
            string destination = Console.ReadLine();

            Console.Write("Days: ");
            int days = int.Parse(Console.ReadLine());

            Console.Write("Price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            tourService.AddTour(new Tour(destination, days, price));

            Console.WriteLine("Tour destination added successfully!");
        }
    }
}
