using System;
using System.Collections.Generic;
using System.Text;

namespace activityoverride1
{
    internal class Card3:payment03
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Payment done using Card");
        }
    }
}
