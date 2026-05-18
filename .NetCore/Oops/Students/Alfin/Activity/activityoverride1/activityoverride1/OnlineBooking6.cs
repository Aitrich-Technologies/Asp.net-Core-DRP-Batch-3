using System;
using System.Collections.Generic;
using System.Text;

namespace activityoverride1
{
    internal class OnlineBooking6:Booking06
    {
        public override void ConfirmBooking()
        {
            Console.WriteLine("Online booking confirmed via website");
        }

    }
}
