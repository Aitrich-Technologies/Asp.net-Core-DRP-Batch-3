using System;
using System.Collections.Generic;
using System.Text;

namespace Ens_1
{
   

class Tour
    {
        
        private string tourName;
        private string destination;
        private double price;

      
        public string TourName
        {
            get { return tourName; }
            set { tourName = value; }
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public double Price

        {
            get { return price; }
            set { price = value; }
        }

        
        public void DisplayDetails()
        {
            Console.WriteLine("Tour Name: " + tourName);
            Console.WriteLine("Destination: " + destination);
            Console.WriteLine("Price: " + price);
        }
    }
}

