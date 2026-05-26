using System;
using System.Collections.Generic;
using System.Text;

namespace ENS
{
    internal class Student
    {
        private int age;
        public void SetAge(int a) {

            if (a > 0) { age = a; }
            
        }

        public int GetAge() { return age;  
        }

    }
}
