using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise3.Interface;
using Excercise3.Models;
using Excercise3.Repository;

namespace Excercise3.Manager
{
  
        public class AgentManager : IMenu
        {
        private User loggedUser;
        private IUserRepository userRepository;
        private ITourProvider Tours;
        private DisplayDetails displayDetails = new DisplayDetails();

        // ✅ FIXED constructor
        public AgentManager(User user, IUserRepository repository, ITourProvider tourRepo)
        {
            loggedUser = user;
            userRepository = repository;
            Tours = tourRepo;
        }

        public void DisplayMenu()
        {
            ShowAgentMenu();
        }
        public void ShowAgentMenu()
        { 
                    Console.WriteLine("\n----- AGENT MENU -----");
                    Console.WriteLine("1.View All Agents");
                    Console.WriteLine("2.View My Profile");
                    Console.WriteLine("3. Add Tour");
                    Console.WriteLine("4. List All Tours");
                    Console.WriteLine("5. Logout");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                case "1":
                    var agents = userRepository.getAllAgent();
                    displayDetails.Print(agents);
                    ShowAgentMenu();
                    break;
                case "2":
                    ViewProfile();
                    ShowAgentMenu();
                    break;
                case "3":
                    Console.WriteLine("Enter the Destination");
                    string destination= Console.ReadLine();
                    Console.WriteLine("Enter the Days");
                    int days=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Price");
                    decimal price=Convert.ToDecimal(Console.ReadLine());
                    Tour tour=new Tour(destination, days, price);
                    Tours.AddTour(tour);
                    Console.WriteLine("Tour Added Successfully");
                    ShowAgentMenu();
                    break;
                    case "4":
                            List<Tour> tours=Tours.GetAllTours();
                            displayDetails.Print(tours);
                            ShowAgentMenu();
                            break;
                     case "5":
                    Logout();
                    break;
                    default:
                     Console.WriteLine("Invalid choice.");
                     ShowAgentMenu();
                     break;
                    }
                }

        public void ViewProfile()
        {
            if (loggedUser == null)
            {
                Console.WriteLine("No user logged in.");
                return;
            }

            Console.WriteLine("\n----- PROFILE -----");
            Console.WriteLine("Name: " + loggedUser.FirstName + " " + loggedUser.LastName);
            Console.WriteLine("Email: " + loggedUser.Email);
            Console.WriteLine("Phone: " + loggedUser.Phone);
            Console.WriteLine("Role: " + loggedUser.Role);
        }
        public void Logout()
        {
            loggedUser = new User();
            Console.WriteLine("Logged out Successfully");
        }
     }
}



