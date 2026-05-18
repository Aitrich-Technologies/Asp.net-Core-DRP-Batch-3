using System;
using System.Collections.Generic;
using System.Text;

namespace Demox
{
    internal class Budgetpackage:Tourpackage
    {
        public double Discount { get; set; }

        public override double CalculatePrice()
        {
            return BasePrice - Discount;
        }
    }
}
