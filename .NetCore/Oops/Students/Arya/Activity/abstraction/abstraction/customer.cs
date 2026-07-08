using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    internal  class customer:Person
    {
        public int id {  get; set; }
        public int licencenumber { get; set; }

        public override void details()
        {
            Console.WriteLine("customerid:"+ id);
            Console.WriteLine("customerlicence number:" + licencenumber);
        }

    }
}
