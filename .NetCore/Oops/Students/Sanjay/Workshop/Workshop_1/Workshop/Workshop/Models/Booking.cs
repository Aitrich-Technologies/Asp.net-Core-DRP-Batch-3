using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop.Models
{
    internal class Booking
    {
        public int BookingId { get; set; }
        public int TourId { get; set; }
        public int UserId { get; set; }
        public int ConsultantId { get; set; }
        public int SeatsBooked {  get; set; }
        public DateTime BookingDate { get; set; }
    }
}
