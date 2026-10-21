using System.ComponentModel.DataAnnotations;

namespace MVC_MechineText11.Dto
{
    public class TourPackageDto
    {
        public Guid Id { get; set; }

        [Required]
        public string PackageName { get; set; } = string.Empty;

        [Required]
        public string Destination { get; set; } = string.Empty;

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Duration { get; set; }

        public string Description { get; set; } = string.Empty;

        public Guid AgencyId { get; set; }
    }
}
