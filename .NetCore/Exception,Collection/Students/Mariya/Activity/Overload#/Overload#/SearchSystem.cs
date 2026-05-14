using System;
using System.Collections.Generic;
using System.Text;

namespace Overload_
{
    internal class SearchSystem
    {
        // Method 1
        public void Search(string keyword)
        {
            Console.WriteLine($"Searching for: {keyword}");
        }

        // Method 2 (Overloaded)
        public void Search(string keyword, string location)
        {
            Console.WriteLine($"Searching for: {keyword} in {location}");
        }
    }
}
