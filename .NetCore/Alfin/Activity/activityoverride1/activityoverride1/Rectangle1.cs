using System;
using System.Collections.Generic;
using System.Text;

namespace activityoverride1
{
    internal class Rectangle1:Shape01
    {
        int length = 4;
        int width = 6;

        public override void Area()
        {
            int area = length * width;
            Console.WriteLine("Rectangle Area = " + area);
        }
    }
}
