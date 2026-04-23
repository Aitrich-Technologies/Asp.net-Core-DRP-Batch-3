using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhertance_activity
{
    internal class Employee
    {
        public int empId;
        public string Name;
        public void displayinfo()
        {
            Console.WriteLine("Id:"+ empId);
            Console.WriteLine( "Name:"+Name);
        }
    }
}
