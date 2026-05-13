using System;
using System.Collections.Generic;
using System.Text;

namespace Demox
{
    internal class Flight:Transpot
    {
        public override void Travel()
        {
            Console.WriteLine("Traveling by Flight - fast and comfortable for long distances.");
        }
    }
}
