using System.ComponentModel.DataAnnotations;

namespace Blazor_Exercise.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }
    }
}
