using System;
using System.Collections.Generic;
using System.Text;

namespace Demox
{
    internal class Standardroom:Hotel
    {
        public override void BookRoom()
        {
            Console.WriteLine($"Standard Room booked at {HotelName}, {Location} - Basic facilities provided.");
        }
    }
}
