using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_activity
{
    internal class Train:Transport
    {
        public override void Travel()
        {

            Console.WriteLine("travelling by train");
        }

    }
}
