using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercise3.Models
{
    public class Destination
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }


        [Required]
        public string Location { get; set; }

        [Required]
        public int Duration { get; set; }

        public string? ImagePath { get; set; }
    }
}
