using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction
{
    internal class StandardRoom:Hotel
    {
        public override void Bookroom()
        {
            Console.WriteLine("Standard room function");
        }
    }
}
