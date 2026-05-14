using System;
using System.Collections.Generic;
using System.Text;

namespace activityabstractoop
{
    internal class LuxuryPackage3:tourpackage3
    {
        public double luxuryprice { get; set; }

        public override double CalculatePrice()
        {
            Console.WriteLine("budget");
            return luxuryprice + baseprice;
        }
    }
}
