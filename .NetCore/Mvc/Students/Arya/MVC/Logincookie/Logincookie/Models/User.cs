using System.ComponentModel.DataAnnotations;

namespace Logincookie.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Role { get; set; }

    }
}
