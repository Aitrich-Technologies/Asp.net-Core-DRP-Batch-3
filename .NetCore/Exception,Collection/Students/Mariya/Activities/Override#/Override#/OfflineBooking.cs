using System;
using System.Collections.Generic;
using System.Text;

namespace Override_
{
    internal class OfflineBooking:Booking
    {
        public override void ConfirmBooking()
        {
            Console.WriteLine("Offline booking confirmed. Please collect receipt.");
        }
    }
}
