using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machinetest
{
    internal class FacultyMember:LibraryMember
    {
        public FacultyMember(int memberId, string name)
        : base(memberId, name)
        {
        }

        
        private double CalculateFacultyFine(int days)
        {
            return days * 0.5; 
        }

        
        public override double CalculateFine(int overdueDays)
        {
            return CalculateFacultyFine(overdueDays);
        }
    }

}

