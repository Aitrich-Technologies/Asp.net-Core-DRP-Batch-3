using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction
{
    internal class UPIPayment:Payment
    {
        public override void MakePayment()
        {
            Console.WriteLine("Make UPI Payment");
        }
    }
}
