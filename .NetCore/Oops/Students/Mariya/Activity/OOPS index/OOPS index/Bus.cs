using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_index
{
    internal class Bus
    {
        public int BusNo;
        public string source;
        public string destination;

        public Bus(int no, string src, string dest)
        {
            BusNo = no;
            source = src;
            destination = dest;
        }
        public void Display()
        {
            Console.WriteLine("Bus No: " + BusNo);
            Console.WriteLine("Source: " + source);
            Console.WriteLine("Destination: " + destination);
        }
    }
}
