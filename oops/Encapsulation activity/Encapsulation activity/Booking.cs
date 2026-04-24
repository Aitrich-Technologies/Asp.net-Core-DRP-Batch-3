using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_activity
{
    internal class Booking
    {
        private string CustomerName;
        private string TourName;
        private int Seats;

        public string customerName
        {
            get { return customerName; }
            set { customerName= value; }

        }
        public string tourname
        {
            get { return tourname; }
            set { tourname = value; }

        }

    }
}
