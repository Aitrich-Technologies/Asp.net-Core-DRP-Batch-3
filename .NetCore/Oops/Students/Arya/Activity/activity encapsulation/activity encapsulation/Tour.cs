using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_activity
{
    internal class Tour
    {
        private string tourname;
        private string destination;
        private double price;

        public void Settourname(string tourname, string destination, int price)
        {
            this.tourname = tourname;
            this.destination = destination;
            if (price > 0)
            {
                this.price = price;
            }
        }
        public string Gettourname()
        {
            return this.destination + this.tourname + price;
        }

    }
}
             
   

