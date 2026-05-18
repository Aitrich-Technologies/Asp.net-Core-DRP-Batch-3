using System;
using System.Collections.Generic;
using System.Text;

namespace oopactivity2
{
    internal class familytravellerprofile4:travelprofile4
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
            Console.WriteLine("Family Members: ");
            Console.WriteLine("Group Tours: ");
        }
    }
}
