using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop1.Models;

namespace workshop1.Interface
{
    public interface IBookingRepository
    {
        void AddBooking(Booking booking);
        Booking[] GetAllBookings();

    }
}
