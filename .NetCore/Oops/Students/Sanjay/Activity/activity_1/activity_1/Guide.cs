using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity_1
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
            Console.WriteLine("Guide ID: " + guideId);
            Console.WriteLine("Guide Name: " + guideName);
            Console.WriteLine("Experience: " + experience + " years");
        }

    }
}
