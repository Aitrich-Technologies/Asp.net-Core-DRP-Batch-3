using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverloading_activity
{
    internal class Displayinfo
    {
        public void Display(string name)
        {
            Console.WriteLine("Name:" + name);
        }
        public void Display(string name, int age)
        {
            Console.WriteLine("Name: " + name + ", Age: " + age);
        }
    }
}
