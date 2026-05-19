using System;
using System.Collections.Generic;
using System.Text;

namespace activityoverride1
{
    internal class DomesticTour5:Tour05
    {
        public override void CalculatePrice()
        {
            int basePrice = 5000;
            int tax = 500;

            int total = basePrice + tax;

            Console.WriteLine("Domestic Tour Price: " + total);
        }
    }
}
