using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverriding_activity
{
    internal class onlinebooking:Booking
    {
        public override void confirmBooking()
        {
            Console.WriteLine("online booking confirmed");
        }
    }
}
