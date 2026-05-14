using System;
using System.Collections.Generic;
using System.Text;

namespace oopsamlpe4
{
    internal class student
    {
        private int age;
        public void Setage(int a)
        {
            if (a > 0) 
                age = a;

        }

        public int Getage()
        {
           return age;
        }
    }
}
