using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop1.Models;
using workshop1.Interface;

namespace workshop1.Repository
{
    public class BookingRepository: IBookingRepository
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
