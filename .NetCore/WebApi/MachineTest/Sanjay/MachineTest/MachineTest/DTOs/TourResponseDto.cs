namespace MachineTest.DTOs
{
    public class TourResponseDto
    {
            public Guid Id { get; set; }
            public string Title { get; set; } = string.Empty;
            public string Destination { get; set; } = string.Empty;
            public string Description { get; set; } = string.Empty;
            public decimal Price { get; set; }
            public int Duration { get; set; }
            public DateTime StartDate { get; set; }
            public Guid CreatedBy { get; set; }
        }
    }



