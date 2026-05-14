using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverriding_activity
{
    internal class Card:Payment
    {
        public override void paymentprocess()
        {
            Console.WriteLine("Payment done using card");
        }
    }
}
