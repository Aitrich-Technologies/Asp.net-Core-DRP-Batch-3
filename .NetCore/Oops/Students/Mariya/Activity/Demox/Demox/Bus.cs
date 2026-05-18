using System;
using System.Collections.Generic;
using System.Text;

namespace Demox
{
    internal class Bus:Transpot
    {
        public override void Travel()
        {
            Console.WriteLine("Traveling by Bus - economical and suitable for short distances.");
        }
    }
}
