namespace MachineTest.Dto
{
    public class BookingDto
    {
        public Guid TourId { get; set; }
        public DateTime BookingDate { get; set; } = DateTime.Now;
    }
}
