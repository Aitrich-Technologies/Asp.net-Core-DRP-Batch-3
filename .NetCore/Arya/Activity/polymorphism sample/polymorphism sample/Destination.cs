using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_sample
{
    internal class Destination:Tour
    {
        public override void addtour()
        {
            Console.WriteLine("destination added");
        }
    }
}
