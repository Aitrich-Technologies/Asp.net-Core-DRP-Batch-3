using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverriding_activity
{
    internal class DomesticTour:Tour
    {
        public override void CalculatePrice()
        {
            Console.WriteLine("Domestic Tour Price:5000");
        }
    }
   

    
}
