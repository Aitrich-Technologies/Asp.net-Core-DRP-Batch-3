using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_index
{
    internal class guide
    {
        public int guideId;
        public string guideName;
        public int experience;
        public guide(int id, string name, int exp)
        {
            guideId = id;
            guideName = name;
            experience = exp;
        }
        public void Display()
        {
            Console.WriteLine("Guide ID: " + guideId);
            Console.WriteLine("Guide Name: " + guideName);
            Console.WriteLine("Experience: " + experience + " years");
        }
    }
}
