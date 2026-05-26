using System;
using System.Collections.Generic;
using System.Text;

namespace method_overrideing
{
    class UPI : Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Payment processed via UPI.");
        }
    }

}
