using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhertance_activity
{
    internal class Solotravellerprofile:Travelprofile
    {
        public string solotrips;
        public string preference;

        public void ShowSoloTravellerProfile()
        {
            Console.WriteLine("solotrips:" + solotrips);    
            Console.WriteLine("Preference:" + preference);
        }

    }
}
