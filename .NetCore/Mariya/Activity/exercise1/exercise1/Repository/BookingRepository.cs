using System;
using System.Collections.Generic;
using System.Text;
using exercise1.Interface;
using exercise1.Models;

namespace exercise1.Repository
{
    //internal class BookingRepository
    //{
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

