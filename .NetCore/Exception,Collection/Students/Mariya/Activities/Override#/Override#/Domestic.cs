using System;
using System.Collections.Generic;
using System.Text;

namespace Override_
{
    internal class Domestic:Tour
    {
        public int Days { get; set; }
        public double CostPerDay { get; set; }

        public Domestic(int days, double costPerDay)
        {
            Days = days;
            CostPerDay = costPerDay;
        }

        public override double CalculatePrice()
        {
            return Days * CostPerDay;
        }
    }
}
