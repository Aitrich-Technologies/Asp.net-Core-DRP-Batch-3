using System;
using System.Collections.Generic;
using System.Text;

namespace Overload_
{
    internal class AreaCalculator
    {
        // Square
        public int Area(int side)
        {
            return side * side;
        }

        // Rectangle
        public int Area(int length, int breadth)
        {
            return length * breadth;
        }
    }
}
