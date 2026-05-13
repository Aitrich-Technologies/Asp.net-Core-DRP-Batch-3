using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    internal class Solotravelprofile:travelprofile
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
