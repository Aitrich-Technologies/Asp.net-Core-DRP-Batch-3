using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_activity
{
    internal abstract class Tour
    {
     public string tourName { get; set; }
     public string destination { get; set; }

        public abstract void ShowDetails();
        
    }
}
