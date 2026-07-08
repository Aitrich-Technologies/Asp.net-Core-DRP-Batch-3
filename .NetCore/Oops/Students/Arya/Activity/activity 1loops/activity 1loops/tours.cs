using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity_1loops
{
    internal class tours
    {
        public int Id;
        public string Name;
        public string Location;
    
        //Default constructor
    public tours()
        {
            Id = 1;
            Name = " summer season";
            Location = "korea";

        }
        public void Disply()
        {
            Console.WriteLine(" Tour Id:" + Id);
            Console.WriteLine(" Tour Name:" + Name);
            Console.WriteLine("Tour Location:" + Location);
                
        }
    }
}
