using System;
using System.Collections.Generic;
using System.Text;

namespace ENS
{
    internal class TOUR
    {
        private string name;
        private string destination;
        private int price;


        public void Setname(string name,string destination,int price)
        {
            this.name = name;
            this.destination = destination;
            if(price>0)
            {
                this.price = price;
            }
        }
         
        public string Getname()
        {
            return this.name + this.destination + price;
        }

        
    }
}
