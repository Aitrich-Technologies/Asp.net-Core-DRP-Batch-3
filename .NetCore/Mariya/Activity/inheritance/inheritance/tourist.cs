using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace inheritance
{
    internal class tourist:user
    {
        public void booktour()
        {
            Console.WriteLine(name + "booked a tour");
        }
    }
}
