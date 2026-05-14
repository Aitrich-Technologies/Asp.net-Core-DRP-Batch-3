using System;
using System.Collections.Generic;
using System.Text;

namespace Overload_
{
    internal class DisplayInfo
    {
        public void Display(string name)
        {
            Console.WriteLine($"Name: {name}");
        }

        // Method 2 (Overloaded)
        public void Display(string name, int age)
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
}
