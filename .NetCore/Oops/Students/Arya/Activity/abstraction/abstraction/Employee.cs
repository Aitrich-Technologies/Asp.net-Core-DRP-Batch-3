using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    internal class Employee:Person
    {
        public int Id { get; set; }
        public string position {  get; set; }

        public override void details()
        {
            Console.WriteLine("employee id :" + Id);
            Console.WriteLine("position:" + position);
        }
    }
}
