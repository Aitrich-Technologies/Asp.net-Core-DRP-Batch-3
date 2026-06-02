using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Models
{
    public class Tour
    {
        public int Id { get; set; }
        public string Destination { get; set; }
        public int Days { get; set; }
        public decimal Price { get; set; }
        public Tour()
        {

        }
        public Tour
            (
             int id,
             string destination,
             int days,
             decimal price
            )
        {
            Id = id;
            Destination = destination;
            Days = days;
            Price = price;
        }
    }
}
