using System;
using System.Collections.Generic;
using System.Text;
using Workshop.Models;

namespace Workshop.Interface
{
    internal interface IBookingRepository
    {
        void Add(Booking b);
        Booking[] GetAll();
    }
}
