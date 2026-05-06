using System;
using System.Collections.Generic;
using System.Text;

namespace method_overrideing
{
    class Cash : Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Payment received in Cash.");
        }
    }
}
