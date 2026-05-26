using System;
using System.Collections.Generic;
using System.Text;

namespace Machinetest_
{
    internal class FacultyMember : LibraryMember
    {
        public FacultyMember(int memberId, string name) :base(memberId,name)
        {

        }

        private double ComputeFine(int overduedays)
        {
            return overduedays * 0.5;
        }

        public override double CalculateFine(int overduedays)
        { 
            return ComputeFine(overduedays);
        }
    }
}
