using System;
using System.Collections.Generic;
using System.Text;

namespace oopsamlpe4
{
    internal class tour
    {
        private string tourname;
        private string destination;
        private int price;

        public void Settourname(string tourname,string destination,int price)
        {
            this.tourname = tourname;
            this.destination = destination;
            if (price>0)
            {
                this.price = price;
                    }
        }
        public string Gettourname()
        {
            return this.destination + this.tourname +price;
        }

    }
}
