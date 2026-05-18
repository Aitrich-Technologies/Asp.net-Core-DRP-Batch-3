using System;
using System.Collections.Generic;
using System.Text;

namespace oopsamlpe4
{
    internal class tour1
    {
        private double price;
        public void setprice(double price)
        {
            if (price < 0)
                Console.WriteLine("Price should not be negative");
            else price = price;
        }
        public double getprice()
        { return price; }
    }
}
