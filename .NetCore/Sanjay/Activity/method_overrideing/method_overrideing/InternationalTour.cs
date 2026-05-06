using System;
using System.Collections.Generic;
using System.Text;

namespace method_overrideing
{
    class InternationalTour : Tour
    {
        public double basePrice;
        public int days;
        public double visaFee;

        public InternationalTour(double price, int d, double visa)
        {
            basePrice = price;
            days = d;
            visaFee = visa;
        }

        public override void CalculatePrice()
        {
            double total = (basePrice * days) + visaFee + 5000; // extra charges
            Console.WriteLine("International Tour Price: " + total);
        }
    }
}
