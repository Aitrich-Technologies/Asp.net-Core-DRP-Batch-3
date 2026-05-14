using Exercise.Interface;
using Exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Repositary
{
    public class BookingRepository : IBookingRepositary
    {
        private Booking[] bookings = new Booking[20];
        private int count = 0;

        public void AddBooking(Booking booking)
        {
            bookings[count++] = booking;
        }

        public Booking[] GetAllBookings()
        {
            return bookings;
        }

    }
}

