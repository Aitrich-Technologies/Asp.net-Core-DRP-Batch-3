using System;
using System.Collections.Generic;
using System.Text;

namespace oopactivity2
{
    internal class guide3:employee3
    {
        public string languages;
        public string expertise;

        public override void GetInfo()
        {
            base.GetInfo();

            Console.Write("Enter Languages Spoken: ");
            languages = Console.ReadLine();

            Console.Write("Enter Tour Expertise: ");
            expertise = Console.ReadLine();
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Role: Guide");
            Console.WriteLine("Languages: ");
            Console.WriteLine("Expertise: ");
        }
    }
}
