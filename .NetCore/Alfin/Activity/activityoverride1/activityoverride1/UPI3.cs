using System;
using System.Collections.Generic;
using System.Text;

namespace activityoverride1
{
    internal class UPI3:payment03
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Payment done using UPI");
        }
    }
}
