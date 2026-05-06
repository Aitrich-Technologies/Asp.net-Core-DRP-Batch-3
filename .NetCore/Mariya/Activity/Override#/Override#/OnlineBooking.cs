using System;
using System.Collections.Generic;
using System.Text;

namespace Override_
{
    internal class OnlineBooking:   Booking
    {
        public override void ConfirmBooking()
        {
            Console.WriteLine("Online booking confirmed. Confirmation email sent.");
        }
    }
}
