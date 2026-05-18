using System;
using System.Collections.Generic;
using System.Text;

namespace activityabstractoop
{
    internal abstract class tour
    {
        public string tourname {  get; set; }
        public string destination { get; set; }
        

        public abstract void ShowDetails();
    }
    
}
