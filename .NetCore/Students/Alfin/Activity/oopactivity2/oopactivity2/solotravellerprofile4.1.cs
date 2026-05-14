using System;
using System.Collections.Generic;
using System.Text;

namespace oopactivity2
{
    internal class solotravellerprofile4:travelprofile4
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
            Console.WriteLine("Preferences: ");
        }
    }
}
