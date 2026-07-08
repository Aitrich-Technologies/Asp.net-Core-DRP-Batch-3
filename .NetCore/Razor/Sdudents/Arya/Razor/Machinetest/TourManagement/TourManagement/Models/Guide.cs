using System.ComponentModel.DataAnnotations;

namespace TourManagement.Models
{
    public class Guide
    {
        public int Id { get; set; }

        [Required]
        public string GuideName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public int Experience { get; set; }
        [Required]
        public string Langauage { get; set; }
    }
}
