using System;
using System.Collections.Generic;
using System.Text;

namespace method_overrideing
{
    class Tour
    {
        public virtual void CalculatePrice()
        {
            Console.WriteLine("Calculating Tour Price...");
        }
    }
}
