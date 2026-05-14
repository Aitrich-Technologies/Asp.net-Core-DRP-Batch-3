using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public string ContactNumber { get; set; }

        public abstract void DisplayDetails();
    }
}
