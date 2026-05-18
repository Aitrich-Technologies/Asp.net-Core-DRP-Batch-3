using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction
{
    internal abstract class TourPackage
    {
        public double baseprice = 1000;

        public abstract double CalculatePrice();
    }
}
