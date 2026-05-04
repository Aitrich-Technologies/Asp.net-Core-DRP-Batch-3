using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machinetest
{
    internal abstract class LibraryMember
    {
        public int MemberId { get; set; }
        public string Name { get; set; }

        public LibraryMember(int memberId, string name)
            {
            MemberId = memberId;
            Name = name;

        }
        public abstract double CalculateFine(int OverDueDays);
    }
}
