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

        public void setBooking(string CustomerName, string TourName, int Seats)
        {
            this.CustomerName = CustomerName;
            this.TourName = TourName;
            if (Seats > 0)
            {
                this.Seats = Seats;
            }

        }
        public string getBooking()
        {
            return this.CustomerName + this.TourName + this.Seats;




        }
    }
}
