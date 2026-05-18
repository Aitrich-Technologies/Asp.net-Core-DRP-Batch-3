using EX_.Enum;
using EX_.Manager;
using EX_.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EX_.Participants
{
   
        public class UserParticipants
        {
            private UserManager userManager;
            private ConsultantManager consultantManager;
            private TourManager tourManager;
            private BookingManager bookingManager;

            public UserParticipants(UserManager u, ConsultantManager c, TourManager t, BookingManager b)
            {
                userManager = u;
                consultantManager = c;
                tourManager = t;
                bookingManager = b;
            }

            public void Start()
            {
                while (true)
                {
                    Console.WriteLine("1. Register\n2. Login");
                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        Console.Write("Username: ");
                        var u = Console.ReadLine();
                        Console.Write("Password: ");
                        var p = Console.ReadLine();

                        userManager.Register(u, p, UserRoles.Customer);
                    }
                    else
                    {
                        Console.Write("Username: ");
                        var u = Console.ReadLine();
                        Console.Write("Password: ");
                        var p = Console.ReadLine();

                        var user = userManager.Login(u, p);

                        if (user == null)
                        {
                            Console.WriteLine("Invalid login");
                            continue;
                        }

                        if (user.Role == UserRoles.Admin)
                            AdminMenu();
                        else if (user.Role == UserRoles.Consultant)
                            ConsultantMenu(user.UserId);
                        else
                            CustomerMenu(user.UserId);
                    }
                }
            }

        void AdminMenu()
        {
            Console.WriteLine("1. Add Consultant\n2. Add Tour");

            int ch = int.Parse(Console.ReadLine());

            if (ch == 1)
            {
                Console.Write("Consultant Name: ");
                consultantManager.(Console.ReadLine());
            }
            else if (ch == 2)
            {
                Console.Write("Destination: ");
                var d = Console.ReadLine();
                Console.Write("Price: ");
                var p = double.Parse(Console.ReadLine());
                Console.Write("Seats: ");
                var s = int.Parse(Console.ReadLine());

                tourManager.AddTour(d, p, s);
            }
        }
            
                private void AddConsultantFlow()
        {
            Console.Write("Enter Consultant Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            // Step 1: Create User
            userManager.Register(username, password, UserRoles.Consultant);

            // Get the created user
            var user = userManager.GetAllUsers()
                        .FirstOrDefault(u => u.Username == username);

            // Step 2: Create Consultant profile
            consultantManager.AddConsultant(name, user.UserId);

            Console.WriteLine("Consultant added successfully!");
        }

            void ConsultantMenu(int consultantId)
            {
                Console.WriteLine("1. View Tours\n2. Book for Customer");

                int ch = int.Parse(Console.ReadLine());

                if (ch == 1)
                {
                    foreach (var t in tourManager.ViewTours())
                        Console.WriteLine($"{t.TourId} {t.Destination} Seats:{t.AvailableSeats}");
                }
            else
            {
                Console.Write("Customer ID: ");
                int customerId = int.Parse(Console.ReadLine());

                Console.Write("Tour ID: ");
                int tourId = int.Parse(Console.ReadLine());

                Console.Write("Seats: ");
                int seats = int.Parse(Console.ReadLine());

                if (bookingManager.BookTour(customerId, consultantId, tourId, seats))
                    Console.WriteLine("Booked!");
                else
                    Console.WriteLine("Failed!");
            }
        }

            void CustomerMenu(int userId)
            {
                foreach (var t in tourManager.ViewTours())
                    Console.WriteLine($"{t.TourId} {t.Destination} Seats:{t.AvailableSeats}");
            }
        }
    }


