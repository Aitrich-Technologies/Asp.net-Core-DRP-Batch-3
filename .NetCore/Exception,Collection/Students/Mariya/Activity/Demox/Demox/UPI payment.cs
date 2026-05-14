using System;
using System.Collections.Generic;
using System.Text;

namespace Demox
{
    internal class UPI_payment:Payment
    {
        public override void MakePayment()
        {
            Console.WriteLine("Payment made using UPI.");
        }
    }
}
