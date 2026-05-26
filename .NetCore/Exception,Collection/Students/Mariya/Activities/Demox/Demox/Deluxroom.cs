using System;
using System.Collections.Generic;
using System.Text;

namespace Demox
{
    internal class Deluxroom:Hotel
    {
        public override void BookRoom()
        {
            Console.WriteLine($"Deluxe Room booked at {HotelName}, {Location} - Premium facilities with luxury experience.");
        }
    }
}
