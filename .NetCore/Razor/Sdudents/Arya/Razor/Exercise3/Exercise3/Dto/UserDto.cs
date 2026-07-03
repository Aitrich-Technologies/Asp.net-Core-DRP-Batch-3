using Exercise3.Enum;
using System.ComponentModel.DataAnnotations;

namespace Exercise3.Dto
{
    public class UserDto
    {

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public RoleType Role { get; set; }
    }
}
