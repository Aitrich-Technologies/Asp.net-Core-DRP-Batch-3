using Exercise.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise.Interface
{
    public interface IBookingRepository
    {
        void AddBooking(Booking booking);
        Booking[] GetAllBookings();

    }
}
