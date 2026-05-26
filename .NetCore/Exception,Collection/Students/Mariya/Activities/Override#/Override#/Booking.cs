using System;
using System.Collections.Generic;
using System.Text;

namespace Override_
{
    internal class Booking
    {
        public virtual void ConfirmBooking()
        {
            Console.WriteLine("Booking confirmed.");
        }
    }
}
