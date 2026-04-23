using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class domestictour:tour
    {
        public string name;
        public string day;
        public int amt;

        
        public void display()
        {
            Console.WriteLine("successfull");
        }

    }
}