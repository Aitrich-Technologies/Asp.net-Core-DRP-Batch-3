using System;
using System.Collections.Generic;
using System.Text;

namespace Override_
{
    internal class Rectangle:Shape
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Rectangle(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public override double Area()
        {
            return Length * Breadth;
        }
    }
}
