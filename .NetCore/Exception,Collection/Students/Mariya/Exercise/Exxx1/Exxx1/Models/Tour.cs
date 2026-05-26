using System;
using System.Collections.Generic;
using System.Text;

namespace Exxx1.Models
{
    public class Tour
    {
        public int TourId { get; set; }

        public string TourName { get; set; }

        public string Destination { get; set; }

        public double Price { get; set; }

        public int DurationDays { get; set; }
    }
}
