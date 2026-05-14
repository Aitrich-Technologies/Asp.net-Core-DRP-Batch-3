using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise3.Enums;

namespace Excercise3.Models
{
    public class Tour
    {
        public int Id { get; set; }

        public string Destination { get; set; }

        public int Days { get; set; }

        public decimal Price { get; set; }

        public Tour(string destination, int days, decimal price)
        {
            Destination = destination;
            Days = days;
            Price = price;
        }
    }
}
