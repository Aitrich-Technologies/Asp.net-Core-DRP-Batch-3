using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction
{
    internal class Bus:Transport
    {
        public override void Travel()
        {
            Console.WriteLine("Bus function");
        }
    }
}
