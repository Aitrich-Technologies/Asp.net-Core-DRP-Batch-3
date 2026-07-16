namespace MachineTest.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public Guid TourId { get; set; }
        public Guid? UserId { get; set; }
        public DateTime BookingDate { get; set; }
        public string status { get; set; }
    }
}
