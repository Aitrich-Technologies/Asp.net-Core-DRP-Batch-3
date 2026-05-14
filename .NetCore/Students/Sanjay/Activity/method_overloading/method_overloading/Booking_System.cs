using System;
using System.Collections.Generic;
using System.Text;

namespace method_overloading
{
    internal class Booking_System
    {
        public int Book(int seats)
        {
            return seats;
        }
        public string Book(int a, string name)
        {
            return a + name;
        }
    }
}
