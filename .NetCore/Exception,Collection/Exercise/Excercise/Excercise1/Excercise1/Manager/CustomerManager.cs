using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise1.Interface;
using Excercise1.Models;
using Excercise1.Repository;

namespace Excercise1.Manager
{
    public class CustomerManager : IMenu
    {
       
            private User loggedUser;
            private TourRepository tourRepository;
            private DisplayDetails display;

            public CustomerManager(User user)
            {
                loggedUser = user;
                tourRepository = new TourRepository();  // Correct repository
                display = new DisplayDetails();
            }

            public void DisplayMenu()
            {
                ShowCustomerMenu();
            }

            private void ShowCustomerMenu()
            {
                Console.WriteLine("\n----- CUSTOMER MENU -----");
                Console.WriteLine("1. View Profile");
                Console.WriteLine("2. View All Tours");
                Console.WriteLine("3. Logout");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewProfile();
                        break;

                    case "2":
                        ViewTours();
                        break;

                    case "3":
                        Logout();
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                ShowCustomerMenu();
            }

            private void ViewProfile()
            {
                display.ShowUserProfile(loggedUser);
            }

            private void ViewTours()
            {
                List<Tour> tours = tourRepository.GetAllTours();
                display.ShowTours(tours);
            }

            private void Logout()
            {
                loggedUser = null;
                Console.WriteLine("Logged out successfully!");
            }
        }
 }



