using Admin_Destination.Interface;
using Admin_Destination.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Destination.Manager
{
    public class BookingManager : IBookingRepository
{

        private TourManager tourManager;

        private Booking[] bookings = new Booking[20];
        private int bookingCounter = 1;
        private int count = 0;

        public BookingManager(TourManager manager)
        {
            tourManager = manager;
        }

        public void BookTour(User user)
        {
            Console.Write("Enter Tour ID: ");
            int tourId = Convert.ToInt32(Console.ReadLine());

            var tour = tourManager.GetTourById(tourId);

            if (tour == null)
            {
                Console.WriteLine("Tour Not Found!");
                return;
            }
            else
            {
                Booking booking = new Booking
                {
                    BookingId = bookingCounter++,
                    TourId = tourId,
                    UserId = user.Id,
                    Destination = tour.Destination,
                    BookingDate = DateTime.Now
                };
                AddBooking(booking);
                Console.WriteLine("Booking Successfull");
            }
        }
        public void AddBooking(Booking booking)
        {
            bookings[count++] = booking;
        }

        public Booking[] GetBookingsByUser(int userId)
        {
            List<Booking> userBookings = new List<Booking>();

            for (int i = 0; i < count; i++)
            {
                if (bookings[i].UserId == userId)
                {
                    userBookings.Add(bookings[i]);
                }
            }

            return userBookings.ToArray();
        }
    }
}
