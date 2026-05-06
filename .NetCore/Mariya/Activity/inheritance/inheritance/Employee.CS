using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    internal class Employee
    {
        public int empId;
        public string Name;
        public void displayinfo()
        {
            Console.WriteLine("Id:" + empId);
            Console.WriteLine("Name:" + Name);
        }
    }
}
