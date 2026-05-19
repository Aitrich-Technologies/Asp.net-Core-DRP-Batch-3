using EXX_.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EXX_.Interface
{
    public interface IBookingRepository
    {
        void AddBooking(Booking booking);
        Booking[] GetAllBookings();

    }
}
