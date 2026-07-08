using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_loop
{
    internal class Bike:Vehicle
    {
        public bool HasCarrier;

        public Bike(string make, string model, int year, string regNo, bool carrier)
            : base(make, model, year, regNo)
        {
            HasCarrier = carrier;
        }

        public override double CalculateRentalCost(int days)
        {
            return days * 20;
        }
    }
}
