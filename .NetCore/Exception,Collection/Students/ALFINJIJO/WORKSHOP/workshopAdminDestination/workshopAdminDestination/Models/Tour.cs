using System;
using System.Collections.Generic;
using System.Text;

namespace workshopAdminDestination.Models
{
   
    
        public class Tour
        {
            public int Id { get; set; }
            public string Destination { get; set; }
            public int Days { get; set; }
            public decimal Price { get; set; }

            public Tour() { }

            public Tour(string destination, int days, decimal price)
            {
                Destination = destination;
                Days = days;
                Price = price;
            }
        }
    
}
