using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Machinetest_
{
    internal class StudentMember:LibraryMember
    {
        public StudentMember(int memberId, string name): base(memberId, name)
        {

        }

        private double ComputeFine(int overduedays)
        {
            return overduedays * 1.0;
        }
        public override double CalculateFine(int overduedays)
        {
            return ComputeFine(overduedays);
        }

    }
}
