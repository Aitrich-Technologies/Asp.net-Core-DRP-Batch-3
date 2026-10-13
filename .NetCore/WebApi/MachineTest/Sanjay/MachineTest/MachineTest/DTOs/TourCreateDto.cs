using System.ComponentModel.DataAnnotations;

namespace MachineTest.DTOs
{
    public class TourCreateDto
    {
        
            [Required]
            [MaxLength(150)]
            public string Title { get; set; } = string.Empty;

            [Required]
            [MaxLength(150)]
            public string Destination { get; set; } = string.Empty;

            [Required]
            public string Description { get; set; } = string.Empty;

            
            public decimal Price { get; set; }

            [Range(1, 365)]
            public int Duration { get; set; }

            public DateTime StartDate { get; set; }
        }
    
}
