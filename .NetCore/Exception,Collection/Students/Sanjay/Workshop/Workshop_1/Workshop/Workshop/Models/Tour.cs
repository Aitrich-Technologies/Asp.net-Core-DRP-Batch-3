using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop.Models
{
    internal class Tour
    {
        public int TourId { get; set; }
        public string Destination { get; set; }
        public double Price { get; set; }
        public int AvailableSeats { get; set; }
    }
}
