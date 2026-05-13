using System;
using System.Collections.Generic;
using System.Text;

namespace method_overrideing
{
    class Card : Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Payment processed using Card.");
        }
    }
}
