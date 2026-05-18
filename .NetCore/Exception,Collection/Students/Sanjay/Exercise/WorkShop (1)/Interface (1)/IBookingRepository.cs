using Admin_Destination.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Destination.Interface
{
    public interface IBookingRepository
{
        void BookTour(User user);

       
        void AddBooking(Booking booking);
}
}
