using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tour t = new Destination();
            t.addtour();

             Tour b = new Booking(); 
            b.addtour();
        }
    }
}
