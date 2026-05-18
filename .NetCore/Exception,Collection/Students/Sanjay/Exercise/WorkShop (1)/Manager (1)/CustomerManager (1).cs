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
    public class CustomerManager : IMenu
    {
        private User loggedUser;

        private ITourService tourService;

        private BookingManager bookingManager;

        private Lists display = new Lists();

        public CustomerManager(
            User user,
            ITourService service,
            BookingManager booking)
        {
            loggedUser = user;

            tourService = service;

            bookingManager = booking;
        }

        public void DisplayMenu()
        {
            bool logout = false;

            while (!logout)
            {
                Console.WriteLine("\n=============== Customer View ============");
                Console.WriteLine("\n1.View Tours");
                Console.WriteLine("2.Book Tour");
                Console.WriteLine("3.My Bookings");
                Console.WriteLine("4.My Profile");
                Console.WriteLine("5.Logout");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        display.PrintTours(tourService.GetTours());
                        break;

                    case "2":
                        bookingManager.BookTour(loggedUser);
                        break;

                    case "3":
                        Booking[] myBookings = bookingManager.GetBookingsByUser(loggedUser.Id);

                        display.PrintBooking(myBookings);

                        //var myBookings =


                        //foreach (var booking in myBookings)
                        //{
                        //    Console.WriteLine("--------------------------------");

                        //    Console.WriteLine($"Booking Id : {booking.BookingId}");

                        //    Console.WriteLine($"Destination : {booking.Destination}");

                        //    Console.WriteLine($"Date : {booking.BookingDate}");
                        //}

                        break;

                    case "4":
                        MyProfile();
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
    }
}
