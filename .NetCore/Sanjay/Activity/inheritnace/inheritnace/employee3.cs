using System;
using System.Collections.Generic;
using System.Text;

namespace inheritnace
{
    internal class employee3
    {
        public int empId;
        public string name;

        public virtual void GetInfo()
        {
            Console.Write("Enter Employee ID: ");
            empId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            name = Console.ReadLine();
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("\nEmployee ID: ");
            Console.WriteLine("Name: " + name);
        }
    }
}
