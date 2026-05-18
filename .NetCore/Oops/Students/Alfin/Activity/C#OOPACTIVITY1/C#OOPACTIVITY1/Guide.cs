using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOPACTIVITY1
{
    internal class Guide
    {
       public int guideId;
       public string guideName;
       public int experience;

        public Guide(int id, string name, int exp)
        {
            guideId = id;
            guideName = name;
            experience = exp;
        }

        public void Display()
        {
            Console.WriteLine(guideId);
            Console.WriteLine(guideName);
            Console.WriteLine(experience);
        }
    }
}
