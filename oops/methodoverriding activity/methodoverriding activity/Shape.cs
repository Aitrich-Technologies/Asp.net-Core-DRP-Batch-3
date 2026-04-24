using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverriding_activity
{
    internal class Shape
    {
        public virtual void Area()
        {
            Console.WriteLine("Calculating Area...");
        }
    }
}
