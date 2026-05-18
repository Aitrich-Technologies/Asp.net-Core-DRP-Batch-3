using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class jobseeker:user
    {
        public int id;
        public string fname;
        public string lname;

        public void Applyjob()
        {
            Console.WriteLine("Applied successfully");
        }
    }
}
