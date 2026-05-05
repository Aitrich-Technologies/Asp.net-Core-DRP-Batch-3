using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_activity
{
    internal class Upipayment:Payment
    {
        public override void Makepayment()
        {

            Console.WriteLine("Payment done using upi.");
        }

    }
}
