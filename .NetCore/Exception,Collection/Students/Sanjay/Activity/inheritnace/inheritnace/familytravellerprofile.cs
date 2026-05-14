using System;
using System.Collections.Generic;
using System.Text;

namespace inheritnace
{
    internal class familytravellerprofile : travelprofile
    {
        public int familyMembers;
        public string groupTours;

        public override void GetDetails()
        {
            base.GetDetails();

            Console.Write("Enter Number of Family Members: ");
            familyMembers = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Preferred Group Tours: ");
            groupTours = Console.ReadLine();
        }

        public override void DisplayProfile()
        {
            base.DisplayProfile();
            Console.WriteLine("Profile Type: Family Traveller");
            Console.WriteLine("Family Members: " + familyMembers);
            Console.WriteLine("Group Tours: " + groupTours);
        }
    }
}