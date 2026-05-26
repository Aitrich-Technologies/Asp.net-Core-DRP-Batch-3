using System;
using System.Collections.Generic;
using System.Text;

namespace inheritnace
{
    internal class solotravellerprofile : travelprofile
    {
        public string preferences;

        public override void GetDetails()
        {
            base.GetDetails();

            Console.Write("Enter Solo Travel Preferences: ");
            preferences = Console.ReadLine();
        }

        public override void DisplayProfile()
        {
            base.DisplayProfile();
            Console.WriteLine("Profile Type: Solo Traveller");
            Console.WriteLine("Preferences: " + preferences);
        }
    }
}
