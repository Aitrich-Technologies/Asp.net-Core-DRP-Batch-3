namespace MachineTest.Dto
{
    public class TourDto
    {
        public Guid TourId { get; set; }
        public string TourName { get; set; } = string.Empty;
        public string Destination { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Status { get; set; } = string.Empty;
        public int AvailableSeat { get; set; }
        public DateOnly DepartureDate { get; set; }
        public DateOnly ArrivalDate { get; set; }
    }
}
