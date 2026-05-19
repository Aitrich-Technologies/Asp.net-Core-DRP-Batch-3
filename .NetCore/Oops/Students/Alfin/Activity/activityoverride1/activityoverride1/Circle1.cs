using System;
using System.Collections.Generic;
using System.Text;

namespace activityoverride1
{
    internal class Circle1:Shape01
    {
        double radius = 5;

        public override void Area()
        {
            double area = 3.14 * radius * radius;
            Console.WriteLine("Circle Area = " + area);
        }
    }
}
