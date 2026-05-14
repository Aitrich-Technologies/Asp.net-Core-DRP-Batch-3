using System;
using System.Collections.Generic;
using System.Text;

namespace Override_
{
    internal class Payment
    {
        public virtual void ProcessPayment()
        {
            Console.WriteLine("Processing generic payment...");
        }
    }
}
