using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction
{
    internal class InternationalTour:Tour
    {
        public string Name { get; set; }
        public override void ShowDetail()
        {
            Console.WriteLine("International Tour: " + Name);
        }
    }
}
