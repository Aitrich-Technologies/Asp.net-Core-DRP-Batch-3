using System;
using System.Collections.Generic;
using System.Text;

namespace Overload_
{
    internal class Payment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount}");
        }

        // Method 2 (Overloaded)
        public void Pay(double amount, string method)
        {
            Console.WriteLine($"Paid {amount} using {method}");
        }
    }
}
