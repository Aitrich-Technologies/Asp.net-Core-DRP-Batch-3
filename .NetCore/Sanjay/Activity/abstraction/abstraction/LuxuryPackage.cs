using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction
{
    internal class LuxuryPackage:TourPackage
    {
        public double luxuryprice {  get; set; }
        
        public override double CalculatePrice()
        {
            Console.WriteLine("budget");
            return luxuryprice + baseprice;
        }
    }
}
