using System;
using System.Collections.Generic;
using System.Text;

namespace method_overrideing
{
    internal class Booking
    {
        public virtual void ConfirmBooking()
        {
            Console.WriteLine("Booking is being processed...");
        }
    }
}
