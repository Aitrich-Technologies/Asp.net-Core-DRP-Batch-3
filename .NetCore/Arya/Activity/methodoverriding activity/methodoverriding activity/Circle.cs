using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverriding_activity
{
    internal class Circle:Shape
    {
        public override void Area()
        {
            Console.WriteLine("Area of Circle = πr²");
        }
    }
}
