using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machinetest
{
    internal class StudentMember:LibraryMember
    {
        public StudentMember(int memberId, string name)
            : base(memberId, name)
        {

        }
        private double CalculateStudentFine(int days)
        {
            return days * 1.0;
        }

        
        public override double CalculateFine(int overdueDays)
        {
            return CalculateStudentFine(overdueDays);
        }
    }
}
