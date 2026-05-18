using Exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Interface
{
    public interface IBookingRepositary
    {
        void AddBooking(Booking booking);
        Booking[] GetAllBookings();

    }
}
