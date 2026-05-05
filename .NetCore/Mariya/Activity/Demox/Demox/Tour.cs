using System;
using System.Collections.Generic;
using System.Text;

namespace Demox
{
    internal abstract class Tour
    {

        // Properties
        public string TourName { get; set; }
        public string Destination { get; set; }

        // Abstract method
        public abstract void ShowDetails();
    }
}
