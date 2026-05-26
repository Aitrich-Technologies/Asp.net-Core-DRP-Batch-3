using System;
using System.Collections.Generic;
using System.Linq;
namespace LQac2_
{
    class TourPackage
    {
        public int TourId { get; set; }
        public string TourName { get; set; }
        public string Destination { get; set; }
        public double PackagePrice { get; set; }
    }
    internal class Program
    {
        static List<TourPackage> tourPackages = new List<TourPackage>();
        static void Main(string[] args)
        {
         

            int choice;

            do
            {
                Console.WriteLine("\n===== TOUR MANAGEMENT SYSTEM =====");
                Console.WriteLine("1. Add Tour Package");
                Console.WriteLine("2. Display All Tour Packages");
                Console.WriteLine("3. Calculate Average Package Price");
                Console.WriteLine("4. Rank Tour Packages");
                Console.WriteLine("5. Remove Tour Package");
                Console.WriteLine("6. Find Tour Package");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");

                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Write("Invalid input! Enter a numeric choice: ");
                }

                switch (choice)
                {
                    case 1:
                        AddTourPackage();
                        break;

                    case 2:
                        DisplayTourPackages();
                        break;

                    case 3:
                        CalculateAveragePrice();
                        break;

                    case 4:
                        RankTourPackages();
                        break;

                    case 5:
                        RemoveTourPackage();
                        break;

                    case 6:
                        FindTourPackage();
                        break;

                    case 7:
                        Console.WriteLine("Exiting application... Thank you!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }

            } while (choice != 7);
        }

      
        static void AddTourPackage()
        {
            Console.WriteLine("\n--- Add Tour Package ---");

            int id;
            Console.Write("Enter Tour ID: ");
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.Write("Invalid input! Enter numeric Tour ID: ");
            }

            string name;
            do
            {
                Console.Write("Enter Tour Name: ");
                name = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(name));

            string destination;
            do
            {
                Console.Write("Enter Destination: ");
                destination = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(destination));

            double price;
            Console.Write("Enter Package Price: ");
            while (!double.TryParse(Console.ReadLine(), out price))
            {
                Console.Write("Invalid input! Enter numeric price: ");
            }

            tourPackages.Add(new TourPackage
            {
                TourId = id,
                TourName = name,
                Destination = destination,
                PackagePrice = price
            });

            Console.WriteLine("Tour Package added successfully!");
        }

      
        static void DisplayTourPackages()
        {
            Console.WriteLine("\n--- Tour Package List ---");

            if (tourPackages.Count == 0)
            {
                Console.WriteLine("No tour packages available.");
                return;
            }

            foreach (var tour in tourPackages)
            {
                Console.WriteLine($"ID: {tour.TourId}");
                Console.WriteLine($"Name: {tour.TourName}");
                Console.WriteLine($"Destination: {tour.Destination}");
                Console.WriteLine($"Price: {tour.PackagePrice}");
                Console.WriteLine("---------------------------");
            }
        }

      
        static void CalculateAveragePrice()
        {
            Console.WriteLine("\n--- Average Package Price ---");

            if (tourPackages.Count == 0)
            {
                Console.WriteLine("No tour packages available.");
                return;
            }

            double average = tourPackages.Average(t => t.PackagePrice);

            Console.WriteLine($"Average Package Price: {average:F2}");
        }

       
        static void RankTourPackages()
        {
            Console.WriteLine("\n--- Ranked Tour Packages ---");

            if (tourPackages.Count == 0)
            {
                Console.WriteLine("No tour packages available.");
                return;
            }

            var rankedTours = tourPackages
                              .OrderByDescending(t => t.PackagePrice)
                              .ToList();

            int rank = 1;

            foreach (var tour in rankedTours)
            {
                Console.WriteLine($"Rank #{rank}");
                Console.WriteLine($"ID: {tour.TourId}");
                Console.WriteLine($"Name: {tour.TourName}");
                Console.WriteLine($"Destination: {tour.Destination}");
                Console.WriteLine($"Price: {tour.PackagePrice}");
                Console.WriteLine("---------------------------");

                rank++;
            }
        }

    
        static void RemoveTourPackage()
        {
            Console.WriteLine("\n--- Remove Tour Package ---");

            int id;
            Console.Write("Enter Tour ID to remove: ");

            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.Write("Invalid input! Enter numeric Tour ID: ");
            }

            var tour = tourPackages.FirstOrDefault(t => t.TourId == id);

            if (tour != null)
            {
                tourPackages.Remove(tour);
                Console.WriteLine("Tour Package removed successfully!");
            }
            else
            {
                Console.WriteLine("Tour Package not found.");
            }
        }

       
        static void FindTourPackage()
        {
            Console.WriteLine("\n--- Find Tour Package ---");
            Console.WriteLine("1. Search by Tour ID");
            Console.WriteLine("2. Search by Tour Name");
            Console.Write("Enter choice: ");

            int option;

            while (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.Write("Invalid input! Enter numeric choice: ");
            }

            switch (option)
            {
                case 1:
                    int id;
                    Console.Write("Enter Tour ID: ");

                    while (!int.TryParse(Console.ReadLine(), out id))
                    {
                        Console.Write("Invalid input! Enter numeric Tour ID: ");
                    }

                    var tourById = tourPackages
                                   .FirstOrDefault(t => t.TourId == id);

                    if (tourById != null)
                    {
                        DisplaySingleTour(tourById);
                    }
                    else
                    {
                        Console.WriteLine("Tour Package not found.");
                    }
                    break;

                case 2:
                    Console.Write("Enter Tour Name: ");
                    string name = Console.ReadLine();

                    var tourByName = tourPackages
                                     .FirstOrDefault(t =>
                                     t.TourName.Equals(name,
                                     StringComparison.OrdinalIgnoreCase));

                    if (tourByName != null)
                    {
                        DisplaySingleTour(tourByName);
                    }
                    else
                    {
                        Console.WriteLine("Tour Package not found.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

      
        static void DisplaySingleTour(TourPackage tour)
        {
            Console.WriteLine("\nTour Package Details");
            Console.WriteLine($"ID: {tour.TourId}");
            Console.WriteLine($"Name: {tour.TourName}");
            Console.WriteLine($"Destination: {tour.Destination}");
            Console.WriteLine($"Price: {tour.PackagePrice}");
        }
    }
}
    

