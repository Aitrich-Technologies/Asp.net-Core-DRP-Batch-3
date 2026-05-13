using System;
using System.Collections.Generic;
using System.Text;

namespace activityoverloadOOP
{
    internal class searchsystem
    {
        public string Search(string keyword)
        {
            return keyword;
        }

        
        public string Search(string keyword, string location)
        {
            return  keyword +  location;
        }
    }
}
