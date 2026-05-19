using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverriding_activity
{
    internal class Payment
    {
        public virtual void paymentprocess()
        {
            Console.WriteLine("Processing Payment...");
        }
    }
}
