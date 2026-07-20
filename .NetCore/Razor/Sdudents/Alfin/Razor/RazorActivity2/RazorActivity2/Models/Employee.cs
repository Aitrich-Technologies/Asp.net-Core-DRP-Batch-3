using System.ComponentModel.DataAnnotations;

namespace RazorActivity2.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        [Range(1000, 100000)]
        public decimal Salary { get; set; }

        [Required]
        public string Department { get; set; }
    }
}
