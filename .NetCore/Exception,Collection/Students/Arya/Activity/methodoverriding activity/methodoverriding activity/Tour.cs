using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverriding_activity
{
    internal class Tour
    {
        public virtual void CalculatePrice()
        {
            Console.WriteLine("calculating tour price");
        }
    }
}
