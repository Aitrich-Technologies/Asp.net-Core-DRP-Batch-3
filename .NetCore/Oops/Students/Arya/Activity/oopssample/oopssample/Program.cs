using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopssample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            s1.id = 1;
            s1.name = "arya";
            s1.mark = 80;
            s1.Display();
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.mark);
            Console.WriteLine(s1.id);
        }
    }
}
