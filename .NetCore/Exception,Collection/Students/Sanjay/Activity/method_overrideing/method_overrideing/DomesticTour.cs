using System;
using System.Collections.Generic;
using System.Text;

namespace method_overrideing
{
    class DomesticTour : Tour
    {
        public double basePrice;
        public int days;

        public DomesticTour(double price, int d)
        {
            basePrice = price;
            days = d;
        }

        public override void CalculatePrice()
        {
            double total = basePrice * days;
            Console.WriteLine("Domestic Tour Price: " + total);
        }
    }
}
