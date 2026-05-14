using System;
using System.Collections.Generic;
using System.Text;

namespace method_overrideing
{
    internal class Circle:Shape
    {
        public double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public override void Area()
        {
            double result = Math.PI * radius * radius;
            Console.WriteLine("Area of Circle: " + result);
        }
    }
}
