using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise3.Models
{
  public class Booking
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int TourId { get; set; }

        public DateTime BookingDate { get; set; }

        public Booking(int userId, int tourId)
        {
            UserId = userId;
            TourId = tourId;
            BookingDate = DateTime.Now;
        }
    }
}

