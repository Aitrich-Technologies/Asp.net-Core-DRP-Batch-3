using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOPACTIVITY1
{
    internal class Bus
    {
       public string busNo;
       public string source;
       public string destination;

        public Bus(string no, string s, string d)
        {
            busNo = no;
            source = s;
            destination = d;
        }

        public void Display()
        {
            Console.WriteLine(busNo);
            Console.WriteLine(source);
            Console.WriteLine(destination);
        }
    }
}
