using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Destination.Models
{
    public class Booking
    {
        
        public int BookingId { get; set; }
        public int TourId { get; set; }
        public int UserId { get; set; }
        public string Destination {  get; set; }
        public DateTime BookingDate { get; set; }

    }
}
