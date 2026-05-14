using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise3.Interface;
using Excercise3.Models;

namespace Excercise3.Manager
{
   public class CustomerManager:IMenu
    {
        private User loggedUser;
        private ITourProvider tourRepository;
        private IBookingRepository bookingRepository;

        public CustomerManager(User user, ITourProvider tourRepo, IBookingRepository bookingRepo)
        {
            loggedUser = user;
            tourRepository = tourRepo;
            bookingRepository = bookingRepo;
        }

        public void DisplayMenu()
        {
            ShowCustomerMenu();
        }

        private void ShowCustomerMenu()
        {
            Console.WriteLine("\n----- CUSTOMER MENU -----");
            Console.WriteLine("1. View Tours");
            Console.WriteLine("2. Book Tour");
            Console.WriteLine("3. View My Bookings");
            Console.WriteLine("4. Logout");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ViewTours();
                    break;

                case "2":
                    BookTour();
                    break;

                case "3":
                    ViewBookings();
                    break;

                case "4":
                    Logout();
                    return;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            ShowCustomerMenu();
        }

     
        private void ViewTours()
        {
            var tours = tourRepository.GetAllTours();

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("{0,-5} {1,-20} {2,10}", "ID", "Destination", "Price");
            Console.WriteLine("-------------------------------------------------------");

            foreach (var tour in tours)
            {
                Console.WriteLine("{0,-5} {1,-20} {2,10:C}",
                    tour.Id,
                    tour.Destination,
                    tour.Price);
            }

            Console.WriteLine("-------------------------------------------------------");
        }
        private void BookTour()
        {
            Console.WriteLine("Enter Tour Id:");
            int tourId = Convert.ToInt32(Console.ReadLine());

            Booking booking = new Booking(loggedUser.Id, tourId);

            bookingRepository.BookTour(booking);

            Console.WriteLine("Tour booked successfully!");
        }

     
        private void ViewBookings()
        {
            var bookings = bookingRepository.GetBookingsByUserId(loggedUser.Id);

            var tours = tourRepository.GetAllTours();

            foreach (var booking in bookings)
            {
                var tour = tours.FirstOrDefault(t => t.Id == booking.TourId);

                if (tour != null)
                {
                    Console.WriteLine($"Booking ID: {booking.Id}");
                    Console.WriteLine($"Destination: {tour.Destination}");
                    Console.WriteLine($"Days: {tour.Days}");
                    Console.WriteLine($"Price: {tour.Price}");
                    Console.WriteLine($"Date: {booking.BookingDate}");
                    Console.WriteLine("----------------------");
                }
            }
        }

        private void Logout()
        {
            Console.WriteLine("Logged out successfully");
        }
    }
}

