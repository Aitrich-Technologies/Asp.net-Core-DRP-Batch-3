using System;
using System.Collections.Generic;
using System.Text;

namespace method_overrideing
{
    class OfflineBooking : Booking
    {
        public override void ConfirmBooking()
        {
            Console.WriteLine("Offline Booking Confirmed. Pay at counter.");
        }
    }
}
