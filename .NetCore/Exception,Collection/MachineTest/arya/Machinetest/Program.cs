using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machinetest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {

                LibraryMember[] members = new LibraryMember[2];

                members[0] = new FacultyMember(1, "Arya");
                members[1] = new StudentMember(2, "Sanjay");

                int overdueDays = 10;

                
                foreach (LibraryMember m in members)
                {
                    Console.WriteLine("Member ID: " + m.MemberId);
                    Console.WriteLine("Name: " + m.Name);
                    Console.WriteLine("Fine: $" + m.CalculateFine(overdueDays));
                    Console.WriteLine("-------------------");
                }


            }
        }
    }
}