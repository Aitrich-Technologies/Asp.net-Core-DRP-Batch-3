using System;
using System.Collections.Generic;
using System.Text;

namespace method_overrideing
{
    class Payment
    {
        public virtual void ProcessPayment()
        {
            Console.WriteLine("Processing payment...");
        }
    }
}
