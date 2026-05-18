using System;
using System.Collections.Generic;
using System.Text;
using Workshop.Interface;
using Workshop.Models;

namespace Workshop.Managers
{
    internal class BookingManager
    {
        private IBookingRepository bookingRepo;
        private ITourRepository tourRepo;
        private TourManager tourManager;

        public BookingManager(IBookingRepository b, ITourRepository t, TourManager tm)
        {
            bookingRepo = b;
            tourRepo = t;
            tourManager = tm;
        }

        public void BookTour(int userId, int consultantId, int tourId, int seats)
        {
            var tour = tourRepo.GetById(tourId);

            if (tour == null)
                throw new Exception("Tour not found");

            if (tour.AvailableSeats < seats)
                throw new Exception("Seats not available");

            tourManager.ReduceSeats(tourId, seats);

            bookingRepo.Add(new Booking
            {
                BookingId = new Random().Next(1000),
                UserId = userId,
                ConsultantId = consultantId,
                TourId = tourId,
                SeatsBooked = seats,
                BookingDate = DateTime.Now
            });
        }

        public Booking[] ViewBookings() => bookingRepo.GetAll();
    }
}
