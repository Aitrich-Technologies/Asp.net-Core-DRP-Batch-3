using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOPACTIVITY1
{
    internal class TOUR
    {
        public int tourId;
        public string tourName;
        public string location;

        public TOUR()
        {
            tourId = 101;
            tourName = "Kerala Trip";
            location = "Munnar";
        }

        public void Display()
        {
            Console.WriteLine(tourId);
            Console.WriteLine(tourName);
            Console.WriteLine(location);
        }
    }
    
}
