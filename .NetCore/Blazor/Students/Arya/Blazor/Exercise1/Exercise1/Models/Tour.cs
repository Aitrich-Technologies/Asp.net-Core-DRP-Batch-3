using System.ComponentModel.DataAnnotations;

namespace Exercise1.Models
{
    public class Tour
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Destination { get; set; }

        public decimal Price { get; set; }
    }
}
