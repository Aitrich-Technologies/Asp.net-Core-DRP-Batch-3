using ExerciseException1.Interface;
using ExerciseException1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseException1.Manager
{
    internal class ConsultantManager
    {
        private User loggedUser;
        private ITourRepository tourRepo;
        private IDestinationRepository destinationRepo;

        public ConsultantManager(User user,
            ITourRepository tour,
            IDestinationRepository destination)
        {
            loggedUser = user;
            tourRepo = tour;
            destinationRepo = destination;
        }

        public void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("1. My Profile");
                Console.WriteLine("2. Add Tour");
                Console.WriteLine("3. View Tour");
                Console.WriteLine("4. Destination");
                Console.WriteLine("5. Logout");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ShowProfile();
                        break;

                    case 2:
                        AddTour();
                        break;

                    case 3:
                        ViewTour();
                        break;

                    case 4:
                        DestinationMenu();
                        break;

                    case 5:
                        return;
                }
            }
        }

        public void ShowProfile()
        {
            List.ShowProfile(loggedUser);
        }

       
        public void AddTour()
        {
            Console.Write("Destination: ");
            string dest = Console.ReadLine();

            Console.Write("Days: ");
            int days = int.Parse(Console.ReadLine());

            Console.Write("Price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Tour tour = new Tour(dest, days, price);


            AddTour(tour); 
        }

        
        public void AddTour(Tour tour)
        {
            tourRepo.AddTour(tour);

            Console.WriteLine("Tour created successfully!");
        }

        public void ViewTour()
        {
            var tours = tourRepo.GetTours();

            List.ShowTours(tours);
        }

        public void DestinationMenu()
        {
            while (true)
            {
                Console.WriteLine("\n===== DESTINATION MENU =====");
                Console.WriteLine("1. Add Destination");
                Console.WriteLine("2. View Destination");
                Console.WriteLine("3. Logout");

                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddDestination();
                        break;

                    case 2:
                        ViewDestination();
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        private void AddDestination()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Description: ");
            string description = Console.ReadLine();

            Destination destination =
                new Destination(0, name, description);

            destinationRepo.AddDestination(destination);

            Console.WriteLine("Destination added successfully!");
        }

        private void ViewDestination()
        {
            var list = destinationRepo.GetDestinations();

            List.ShowDestinations(list);
        }
    }
}
