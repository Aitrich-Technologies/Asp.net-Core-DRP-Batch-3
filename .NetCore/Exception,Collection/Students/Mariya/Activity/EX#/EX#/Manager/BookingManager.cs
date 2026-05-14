using EX_.Enum;
using EX_.InterFace;
using EX_.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EX_.Manager
{
    public class BookingManager
    {
        private IBookingRepository repo;
        private TourManager tourManager;
        private int idCounter = 1;

        public BookingManager(IBookingRepository repo, TourManager tourManager)
        {
            this.repo = repo;
            this.tourManager = tourManager;
        }

        public bool BookTour(int userId, int consultantId, int tourId, int seats)
        {
            if (!tourManager.ReduceSeats(tourId, seats))
                return false;

            repo.Add(new Booking
            {
                BookingId = idCounter++,
                UserId = userId,
                ConsultantId = consultantId,
                TourId = tourId,
                SeatsBooked = seats,
                BookingDate = DateTime.Now
            });

            return true;
        }

        public Booking[] ViewBookings() => repo.GetAll();
    }

}
