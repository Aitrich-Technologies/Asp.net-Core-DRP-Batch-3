using System;
using System.Collections.Generic;
using System.Text;

namespace Override_
{
    internal class Cash:Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Payment processed using Cash.");
        }
    }
}
