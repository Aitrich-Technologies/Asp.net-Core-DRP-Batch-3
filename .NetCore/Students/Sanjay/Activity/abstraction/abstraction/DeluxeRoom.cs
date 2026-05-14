using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction
{
    internal class DeluxeRoom:Hotel
    {
        public override void Bookroom()
        {
            Console.WriteLine("Deluxe room function");
        }
    }
}
