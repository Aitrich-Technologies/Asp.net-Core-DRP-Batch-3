using System;
using System.Collections.Generic;
using System.Text;
using WRK_.Models;

namespace WRK_.Interface
{

    public interface IBookingRepository
    {
        void AddBooking(Booking booking);
        Booking[] GetAllBookings();

    }
}

