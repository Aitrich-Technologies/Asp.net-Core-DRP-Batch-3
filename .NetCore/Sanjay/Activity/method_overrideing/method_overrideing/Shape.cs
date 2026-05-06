using System;
using System.Collections.Generic;
using System.Text;

namespace method_overrideing
{
    internal class Shape
    {
        public virtual void Area()
        {
            Console.WriteLine("Calculating Area");
        }
    }
}
