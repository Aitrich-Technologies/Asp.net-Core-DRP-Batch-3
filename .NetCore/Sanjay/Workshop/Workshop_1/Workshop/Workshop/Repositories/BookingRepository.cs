using System;
using System.Collections.Generic;
using System.Text;
using Workshop.Interface;
using Workshop.Models;

namespace Workshop.Repositories

    {
    internal class BookingRepository : IBookingRepository
    {
        private Booking[] bookings = new Booking[0];

        public void Add(Booking b)
        {
            var newArr = new Booking[bookings.Length + 1];
            for (int i = 0; i < bookings.Length; i++)
                newArr[i] = bookings[i];

            newArr[bookings.Length] = b;
            bookings = newArr;
        }

        public Booking[] GetAll() => bookings;
    }

}
