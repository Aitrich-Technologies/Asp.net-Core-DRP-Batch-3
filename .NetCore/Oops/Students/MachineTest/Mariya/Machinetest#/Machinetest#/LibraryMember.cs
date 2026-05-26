using System;
using System.Collections.Generic;
using System.Text;

namespace Machinetest_
{
    public abstract class LibraryMember
    {
        public int MemberId;
        public string Name;

 public LibraryMember(int memberId, string name)
        {
            MemberId = memberId;
            Name = name;
        }
        public abstract double CalculateFine(int overduedays);
    }
}
