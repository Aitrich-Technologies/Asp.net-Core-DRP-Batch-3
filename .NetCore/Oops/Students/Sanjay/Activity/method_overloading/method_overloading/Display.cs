using System;
using System.Collections.Generic;
using System.Text;

namespace method_overloading
{
    internal class Display
    {
        public string Show(string name)
        {
            return name;
        }
        public string Show(string name, int age)
        {
            return name + age;
            
        }
        
    }
}
