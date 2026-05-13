using System;
using System.Collections.Generic;
using System.Text;

namespace method_overrideing
{
    internal class Rectangle:Shape

    {
        public double length, width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        public override void Area()
        {
            double result = length * width;
            Console.WriteLine("Area of Rectangle: " + result);
        }
    }
}
