using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise3.Interface;
using Excercise3.Models;

namespace Excercise3.Repository
{
     public class BookingRepository:IBookingRepository
    {
        private List<Booking> bookings = new List<Booking>();

        public void BookTour(Booking booking)
        {
            booking.Id = bookings.Count + 1;
            bookings.Add(booking);
        }

        public List<Booking> GetBookingsByUserId(int userId)
        {
            return bookings.Where(b => b.UserId == userId).ToList();
        }
    }
}

