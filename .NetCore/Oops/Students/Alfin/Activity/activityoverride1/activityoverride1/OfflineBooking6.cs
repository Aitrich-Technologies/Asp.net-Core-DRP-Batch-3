using System;
using System.Collections.Generic;
using System.Text;

namespace activityoverride1
{
    internal class OfflineBooking6:Booking06
    {
        public override void ConfirmBooking()
        {
            Console.WriteLine("Offline booking confirmed at office");
        }
    }
}
