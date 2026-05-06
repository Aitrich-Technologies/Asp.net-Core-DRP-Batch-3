using System;
using System.Collections.Generic;
using System.Text;

namespace method_overloading
{
    internal class Class1
    {
        public int Area(int side)
        {
            return side * side;
        }
        public int Area(int length, int breadth)
        {
            return length * breadth;
        }
    }
}
