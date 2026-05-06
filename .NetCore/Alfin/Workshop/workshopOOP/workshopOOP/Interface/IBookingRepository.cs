using System;
using System.Collections.Generic;
using System.Text;
using workshopOOP.Model;

namespace workshopOOP.Interface
{
    public interface IBookingRepository
    {
        void AddBooking(Booking booking);
        Booking[] GetAllBookings();

    }
}
