using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction
{
    internal class BudgetPackage:TourPackage
    {
        public double budgetprice { get; set; }

        public override double CalculatePrice()
        {
            Console.WriteLine("budget");
            return baseprice - budgetprice;
        }
    }
}
