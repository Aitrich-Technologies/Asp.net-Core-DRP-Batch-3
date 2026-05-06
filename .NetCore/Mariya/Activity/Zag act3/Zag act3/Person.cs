using System;
using System.Collections.Generic;
using System.Text;

namespace Zag_act3
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public string ContactNumber { get; set; }

        public Person(string name, string contact)
        {
            Name = name;
            ContactNumber = contact;
        }

        public abstract void DisplayDetails();
    }
}
