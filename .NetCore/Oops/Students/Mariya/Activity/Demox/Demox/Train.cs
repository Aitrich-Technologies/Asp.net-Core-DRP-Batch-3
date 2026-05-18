using System;
using System.Collections.Generic;
using System.Text;

namespace Demox
{
    internal class Train:Transpot
    {
        public override void Travel()
        {
            Console.WriteLine("Traveling by Train - affordable and convenient for medium to long distances.");
        }
    }
}
