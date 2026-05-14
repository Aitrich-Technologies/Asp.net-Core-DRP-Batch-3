using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction
{
    internal class Train:Transport
    {
        public override void Travel()
        {
            Console.WriteLine("Train");
        }
    }
}
