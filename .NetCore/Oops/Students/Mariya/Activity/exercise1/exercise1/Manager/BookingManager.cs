using System;
using System.Collections.Generic;
using System.Text;
using exercise1.Interface;
using exercise1.Models;
using exercise1.Manager;

namespace exercise1.Manager
{
    //internal class BookingManager
    //{
        public class BookingManager
        {
            private IBookingRepository _bookingRepository;
            private TourManager _tourManager;
            private int bookingCounter = 1;

            public BookingManager(IBookingRepository bookingRepository, TourManager tourManager)
            {
                _bookingRepository = bookingRepository;
                _tourManager = tourManager;
            }
            public void BookTour(int userId)
            {
                Console.Write("Enter Tour ID: ");
                int tourId = Convert.ToInt32(Console.ReadLine());

                var tour = _tourManager.GetTourById(tourId);

                if (tour == null)
                {
                    Console.WriteLine("Tour Not Found!");
                    return;
                }
                Console.Write("Enter Seats to Book: ");
                int seats = Convert.ToInt32(Console.ReadLine());

                bool seatReduced = _tourManager.ReduceSeats(tour, seats);

                if (seatReduced)
                {
                    Booking booking = new Booking
                    {
                        BookingId = bookingCounter++,
                        TourId = tourId,
                        UserId = userId,
                        SeatsBooked = seats,
                        BookingDate = DateTime.Now
                    };
                    _bookingRepository.AddBooking(booking);

                    Console.WriteLine("Booking Successful!");
                }
                else
                {
                    Console.WriteLine("Not Enough Seats!");
                }
            }

            public void ViewBookings()
            {
                var bookings = _bookingRepository.GetAllBookings();

                foreach (var booking in bookings)
                {
                    if (booking != null)
                        booking.Display();
                }
            }
        }
    }

