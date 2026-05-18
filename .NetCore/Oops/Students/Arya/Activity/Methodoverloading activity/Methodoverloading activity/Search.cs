using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverloading_activity
{
    internal class Search
    {
        public void search(string keyword)
        {
            Console.WriteLine("Searching for: " + keyword);
        }

        public void search(string keyword, string location)
        {
            Console.WriteLine("Searching for " + keyword + " in " + location);
        }
    }
}
