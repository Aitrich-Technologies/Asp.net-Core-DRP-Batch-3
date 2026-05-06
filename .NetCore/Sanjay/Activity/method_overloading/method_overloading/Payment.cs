using System;
using System.Collections.Generic;
using System.Text;

namespace method_overloading
{
    internal class Payment
    {
        public double Pay(double amount)
        {
            return amount;
        }
        public void Pay(double amount, string method)
        {
            Console.WriteLine("Paid " + amount + "using" + method);
            //return amount + method;
        }
        
    }
}
