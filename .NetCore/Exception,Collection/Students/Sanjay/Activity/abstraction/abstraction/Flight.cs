using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction
{
    internal class Flight:Transport
    {
        public override void Travel()
        {
            Console.WriteLine("Flight");
        }
    }
}
