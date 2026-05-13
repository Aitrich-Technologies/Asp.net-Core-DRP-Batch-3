using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction
{
    internal class DomesticTour:Tour
    {
        public int id;
        public override void ShowDetail()
        {
            Console.WriteLine("Domestic tour: " + id);
        }
    }
}
