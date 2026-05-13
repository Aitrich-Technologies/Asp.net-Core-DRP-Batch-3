using System;
using System.Collections.Generic;
using System.Text;

namespace method_overloading
{
    internal class Search_function
    {
        public string Tour(string keyword)
        {
            return keyword;
        }
        public string Tour(string keyword, string Location)
        {
            return keyword + Location;
        }
    }
}
