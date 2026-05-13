using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhertance_activity
{
    internal class Familytravellerprofile:Travelprofile
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
