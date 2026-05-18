using System;
using System.Collections.Generic;
using System.Text;

namespace Demox
{
    internal class Luxuarypackage:Tourpackage
    {

        public double ExtraCharges { get; set; }

        public override double CalculatePrice()
        {
            return BasePrice + ExtraCharges;
        }
    }
}
