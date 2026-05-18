using System;
using System.Collections.Generic;
using System.Text;
using exercise1.Models;

namespace exercise1.Interface
{

    public interface IBookingRepository
    {
        void AddBooking(Booking booking);
        Booking[] GetAllBookings();

    }
}

