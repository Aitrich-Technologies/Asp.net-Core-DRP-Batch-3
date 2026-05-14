using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction
{
    internal class CardPayment:Payment
    {
        public override void MakePayment()
        {
            Console.WriteLine("Make Card Payment");
        }
    }
}
