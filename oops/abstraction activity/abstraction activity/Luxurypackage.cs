using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_activity
{
    internal class Luxurypackage:Tourpackage
    {
        public override double CalculatePrice()
        {
            return Baseprice + 5000; 
        }
    }
}
