using ExerciseOop1.Interface;
using ExerciseOop1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseOop1.Repository
{

    public class BookingRepository : IBookingRepository
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
