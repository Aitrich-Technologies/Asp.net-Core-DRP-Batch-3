using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverriding_activity
{
    internal class International_Tour:Tour
    {
        public override void CalculatePrice()
        {
            Console.WriteLine("International Tour Price:5000");
        }
    }
}
