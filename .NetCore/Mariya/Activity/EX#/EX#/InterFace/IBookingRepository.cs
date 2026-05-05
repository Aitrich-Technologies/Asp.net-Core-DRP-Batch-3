using EX_.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EX_.InterFace
{
    public interface IBookingRepository
     {
        void Add(Booking booking);
        Booking[] GetAll();
    }
}
