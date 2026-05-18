using System;
using System.Collections.Generic;
using System.Text;

namespace activityoverride1
{
    internal class InternationalTour5:Tour05
    {
        public override void CalculatePrice()
        {
            int basePrice = 20000;
            int visaFee = 3000;
            int tax = 2000;

            int total = basePrice + visaFee + tax;

            Console.WriteLine("International Tour Price: " + total);
        }
    }
}
