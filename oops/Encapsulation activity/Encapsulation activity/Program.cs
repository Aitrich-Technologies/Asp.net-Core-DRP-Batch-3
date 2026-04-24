using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_activity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tour t = new Tour();
            t.Tourname= "Kerala Trip";
            t.Destination = "Munnar";
            t.Price = 10000;
            t.ApplyDiscount(10);
            t.Display();

            Console.WriteLine();
        }
    }
}
