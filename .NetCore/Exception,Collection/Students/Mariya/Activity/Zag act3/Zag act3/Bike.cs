using System;
using System.Collections.Generic;
using System.Text;

namespace Zag_act3
{
    internal class Bike:Vehicle
    {
        public bool HasCarrier { get; set; }

        public Bike(string make, string model, int year, string regNo, bool hasCarrier)
            : base(make, model, year, regNo)
        {
            HasCarrier = hasCarrier;
        }

        public override double CalculateRentalCost(int days)
        {
            return days * 20; // $20 per day
        }
    }
}
