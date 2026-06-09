using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int TourId { get; set; }
        public int UserId { get; set; }
        public int SeatsBooked { get; set; }
        public DateTime BookingDate { get; set; }

        public void Display()
        {
            Console.WriteLine($"BookingID: {BookingId} | TourID: {TourId} | Seats: {SeatsBooked} | Date: {BookingDate}");
        }
    }
}
