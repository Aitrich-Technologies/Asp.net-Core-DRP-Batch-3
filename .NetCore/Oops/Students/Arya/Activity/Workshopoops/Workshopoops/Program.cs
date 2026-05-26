using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshopoops.Enum;
using Workshopoops.Interface;
using Workshopoops.Manager;
using Workshopoops.Repositary;

namespace Workshopoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // Create Repository Objects
                IUserRepository userRepo = new UserRepository();
                ITourRepository tourRepo = new TourRepository();
                IBookingRepository bookingRepo = new BookingRepository();

                // Create Manager Objects
                UserManager userManager = new UserManager(userRepo);
                TourManager tourManager = new TourManager(tourRepo);
                BookingManager bookingManager = new BookingManager(bookingRepo, tourManager);
                while (true)
                {
                    Console.WriteLine("\n==== TOUR BOOKING SYSTEM ====");
                    Console.WriteLine("1. Register");
                    Console.WriteLine("2. Login");
                    Console.WriteLine("3. Exit");
                    Console.Write("Select Option: ");

                    int mainChoice = Convert.ToInt32(Console.ReadLine());
                    switch (mainChoice)
                    {
                        case 1:
                            userManager.Register();
                            break;

                        case 2:
                            var loggedUser = userManager.Login();

                            if (loggedUser == null)
                                break;

                            if (loggedUser.Role == UserRoles.Agency)
                            {
                                AdminMenu(tourManager, bookingManager);
                            }
                            else
                            {
                                CustomerMenu(tourManager, bookingManager, loggedUser.UserId);
                            }
                            break;

                        case 3:
                            return;

                        default:
                            Console.WriteLine("Invalid Option!");
                            break;
                    }
                }
            } // ================= ADMIN MENU =================
            static void AdminMenu(TourManager tourManager, BookingManager bookingManager)
            {
                while (true)
                {
                    Console.WriteLine("\n==== ADMIN MENU ====");
                    Console.WriteLine("1. Add Tour");
                    Console.WriteLine("2. View Tours");
                    Console.WriteLine("3. View All Bookings");
                    Console.WriteLine("4. Logout");
                    Console.Write("Select Option: ");

                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            tourManager.AddTour();
                            break;

                        case 2:
                            tourManager.ViewTours();
                            break;

                        case 3:
                            bookingManager.ViewBookings();
                            break;

                        case 4:
                            return;

                        default:
                            Console.WriteLine("Invalid Option!");
                            break;
                    }
                }
            }
        }
    }
}
