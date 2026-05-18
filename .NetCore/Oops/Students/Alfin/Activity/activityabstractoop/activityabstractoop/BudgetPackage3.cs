using System;
using System.Collections.Generic;
using System.Text;

namespace activityabstractoop
{
    internal class BudgetPackage3: tourpackage3
    {
        public double budgetprice {  get; set; }

        public override double CalculatePrice()
        {
            Console.WriteLine("budget");
            return baseprice - budgetprice;
        }
    }
}
