using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction
{
    internal abstract class Tour
    {
        public string tourname;
        public string destination;

        public abstract void ShowDetail();
    }
}
