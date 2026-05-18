using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public double phonenumber { get; set; }

        public abstract void details();
        

        
    }
}
