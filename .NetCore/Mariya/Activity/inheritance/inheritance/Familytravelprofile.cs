using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    internal class Familytravelprofile:travelprofile
    {
        public string familymembers;
        public int grouptours;

        public void ShowFamilyTravellerProfile()
        {
            Console.WriteLine("Familymembers:" + familymembers);
            Console.WriteLine("Grouptours:" + grouptours);
        }
    }
}
