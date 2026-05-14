using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise3.Models;

namespace Excercise3.Interface
{
    public interface IBookingRepository
    {
        void BookTour(Booking booking);

        List<Booking> GetBookingsByUserId(int userId);
    }
}

