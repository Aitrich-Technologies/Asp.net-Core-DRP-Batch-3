using System;
using System.Collections.Generic;
using System.Text;
using Workshop.Enum;
using Workshop.Managers;

namespace Workshop.Participants
{
    internal class UserParticipants
    {
        private UserManager userManager;
        private TourManager tourManager;
        private BookingManager bookingManager;
        private ConsultantManager consultantManager;

        public UserParticipants(UserManager u, TourManager t, BookingManager b, ConsultantManager c)
        {
            userManager = u;
            tourManager = t;
            bookingManager = b;
            consultantManager = c;
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\n1.Register\n2.Login\n3.Exit");
                int ch = int.Parse(Console.ReadLine());

                if (ch == 1)
                {
                    Console.Write("Username: ");
                    string u = Console.ReadLine();

                    Console.Write("Password: ");
                    string p = Console.ReadLine();

                    Console.Write("Role (0=Admin,1=Consultant,2=Customer): ");
                    int r = int.Parse(Console.ReadLine());

                    userManager.Register(u, p, (UserRoles)r);
                }
                else if (ch == 2)
                {
                    Console.Write("Username: ");
                    string u = Console.ReadLine();

                    Console.Write("Password: ");
                    string p = Console.ReadLine();

                    var user = userManager.Login(u, p);

                    if (user == null)
                    {
                        Console.WriteLine("Invalid Login");
                        continue;
                    }
                    Console.WriteLine("Logged Role: " + user.Role);

                    if (user.Role == UserRoles.Admin)
                    {
                        AdminMenu();
                    }
                    else if (user.Role == UserRoles.Consultant)
                    {
                        ConsultantMenu(user.UserId);
                    }
                    else if (user.Role == UserRoles.Customer)
                    {
                        CustomerMenu(user.UserId);
                    }
                }
                else if (ch == 3)
                {
                    break;
                }
            }
        }

        private void AdminMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- ADMIN MENU ---");
                Console.WriteLine("1. Add Tour");
                Console.WriteLine("2. View Tours");
                Console.WriteLine("3. Add Consultant");
                Console.WriteLine("4. View Consultants");
                Console.WriteLine("5. Logout");

                int ch = int.Parse(Console.ReadLine());

                if (ch == 1)
                {
                    Console.Write("Destination: ");
                    string d = Console.ReadLine();

                    Console.Write("Price: ");
                    double p = double.Parse(Console.ReadLine());

                    Console.Write("Seats: ");
                    int s = int.Parse(Console.ReadLine());

                    tourManager.AddTour(d, p, s);
                }
                else if (ch == 2)
                {
                    var tours = tourManager.ViewTours();

                    foreach (var t in tours)
                        Console.WriteLine($"{t.TourId} | {t.Destination} | {t.Price} | Seats:{t.AvailableSeats}");
                }
                else if (ch == 3)
                {
                    Console.Write("Consultant Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Username: ");
                    string username = Console.ReadLine();

                    Console.Write("Password: ");
                    string password = Console.ReadLine();

                    
                    userManager.Register(username, password, UserRoles.Consultant);

                    
                    consultantManager.AddConsultant(name);

                    Console.WriteLine("Consultant created successfully!");
                }
                else if (ch == 4)
                {
                    var cons = consultantManager.ViewConsultants();

                    foreach (var c in cons)
                        Console.WriteLine($"{c.ConsultantId} | {c.Name} | Customers:{c.AssignedCustomers}");
                }
                else if (ch == 5)
                {
                    break; 
                }

            }
        }



        private void ConsultantMenu(int consultantUserId)
        {
            while (true)
            {
                Console.WriteLine("\n--- CONSULTANT MENU ---");
                Console.WriteLine("1. View Tours");
                Console.WriteLine("2. View Bookings");
                Console.WriteLine("3. Logout");

                int ch = int.Parse(Console.ReadLine());

                if (ch == 1)
                {
                    foreach (var t in tourManager.ViewTours())
                    {
                        Console.WriteLine($"{t.TourId} | {t.Destination} | Seats:{t.AvailableSeats}");
                    }
                }
                else if (ch == 2)
                {
                    foreach (var b in bookingManager.ViewBookings())
                    {
                        Console.WriteLine($"BookingId:{b.BookingId} | Tour:{b.TourId} | User:{b.UserId} | Seats:{b.SeatsBooked}");
                    }
                }
                else if (ch == 3)
                {
                    break;
                }
            }
        }

        private void CustomerMenu(int userId)
        {
            while (true)
            {
                Console.WriteLine("\n--- CUSTOMER MENU ---");
                Console.WriteLine("1. View Tours");
                Console.WriteLine("2. Book Tour");
                Console.WriteLine("3. Logout");

                int ch = int.Parse(Console.ReadLine());

                if (ch == 1)
                {
                    foreach (var t in tourManager.ViewTours())
                        Console.WriteLine($"{t.TourId} | {t.Destination} | Seats:{t.AvailableSeats}");
                }
                else if (ch == 2)
                {
                    Console.Write("TourId: ");
                    int tid = int.Parse(Console.ReadLine());

                    Console.Write("Seats: ");
                    int seats = int.Parse(Console.ReadLine());

                    Console.Write("ConsultantId: ");
                    int cid = int.Parse(Console.ReadLine());

                    try
                    {
                        bookingManager.BookTour(userId, cid, tid, seats);
                        consultantManager.AssignCustomer(cid); 
                        Console.WriteLine("Booking Success");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (ch == 3)
                {
                    break;
                }
            }
        }
    }
}
