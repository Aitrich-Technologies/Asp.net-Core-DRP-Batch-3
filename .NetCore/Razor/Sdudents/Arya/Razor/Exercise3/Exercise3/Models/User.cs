using Exercise3.Enum;
using System.ComponentModel.DataAnnotations;

namespace Exercise3.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public RoleType Role { get; set; }
    }
}
