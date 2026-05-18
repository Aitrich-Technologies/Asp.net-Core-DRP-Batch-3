using System;
using System.Collections.Generic;
using System.Text;

namespace method_overrideing
{
    class OnlineBooking : Booking
    {
        public override void ConfirmBooking()
        {
            Console.WriteLine("Online Booking Confirmed. Payment done via online mode.");
        }
    }
}
