using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOPACTIVITY1
{
    internal class Tourist
    {
       public int touristId;
        public string touristName;
        public int age;

        public Tourist(int id, string name, int a)
        {
            touristId = id;
            touristName = name;
            age = a;
        }

        public void Display()
        {
            Console.WriteLine(touristId);
            Console.WriteLine(touristName);
            Console.WriteLine(age);
        }
    }
}
