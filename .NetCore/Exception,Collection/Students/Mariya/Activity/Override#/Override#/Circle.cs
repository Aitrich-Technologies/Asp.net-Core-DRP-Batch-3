using System;
using System.Collections.Generic;
using System.Text;

namespace Override_
{
    internal class Circle:Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
