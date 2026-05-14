using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs
{
    internal class Bike:Vehicle
    {
        public bool HasCarrier;

        public Bike(string make, string model, int year, string reg, bool carrier) : base(make, model, year, reg)
        {
           HasCarrier = carrier;
        }

        public override double CalculateRentalCost(int days)
        {
            return days * 50;
        }
    }
}
