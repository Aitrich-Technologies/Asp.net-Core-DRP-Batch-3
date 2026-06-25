namespace Workshop_Razor.Models
{
    public class Tours
    {
        public int Id { get; set; }
        public string TourName { get; set; }
        public string Destination { get; set; }
        public decimal Price { get; set; }
        public int Duration { get; set; }
        public DateTime Date { get; set; }

    }
}
