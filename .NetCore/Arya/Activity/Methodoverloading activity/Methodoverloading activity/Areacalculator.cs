using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverloading_activity
{
    internal class Areacalculator
    {
        public void  area(int side)
        {
            Console.WriteLine("square area:" + (side * side));
        }
        public void area(int length,int breadth)
        {
            Console.WriteLine("Rectangle area:" + (length * breadth));
        }
    }
}
