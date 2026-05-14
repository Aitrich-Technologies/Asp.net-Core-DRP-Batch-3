using System;
using System.Collections.Generic;
using System.Text;

namespace Override_
{
    internal class UPI:Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Payment processed using UPI.");
        }
    }
}
