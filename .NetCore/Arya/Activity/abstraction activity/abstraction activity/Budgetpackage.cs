using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_activity
{
    internal class Budgetpackage:Tourpackage
    {
        public override double CalculatePrice()
        {
            return Baseprice - 1000; 
        }
    }
}
