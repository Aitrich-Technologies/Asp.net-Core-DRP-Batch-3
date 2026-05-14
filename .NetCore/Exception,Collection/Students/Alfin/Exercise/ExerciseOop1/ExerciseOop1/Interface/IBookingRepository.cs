using ExerciseOop1.Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ExerciseOop1.Interface
{
    public interface IBookingRepository
    {
        void AddBooking(Booking booking);
        Booking[] GetAllBookings();

    }

}

