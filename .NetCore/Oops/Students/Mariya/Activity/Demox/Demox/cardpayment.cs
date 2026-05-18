using System;
using System.Collections.Generic;
using System.Text;

namespace Demox
{
    internal class cardpayment:Payment
    {

        public override void MakePayment()
        {
            Console.WriteLine("Payment made using Credit/Debit Card.");
        }
    }
}
