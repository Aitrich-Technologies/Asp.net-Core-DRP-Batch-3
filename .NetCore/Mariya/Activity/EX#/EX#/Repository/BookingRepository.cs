using EX_.InterFace;
using EX_.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EX_.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private Booking[] bookings = new Booking[0];

        public void Add(Booking booking)
        {
            var newArr = new Booking[bookings.Length + 1];

            for (int i = 0; i < bookings.Length; i++)
                newArr[i] = bookings[i];

            newArr[^1] = booking;
            bookings = newArr;
        }

        public Booking[] GetAll()
        {
            return (Booking[])bookings.Clone();
        }
    }
}
