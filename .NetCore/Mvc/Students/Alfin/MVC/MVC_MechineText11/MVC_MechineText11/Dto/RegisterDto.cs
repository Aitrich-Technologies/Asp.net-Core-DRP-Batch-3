using MVC_MechineText11.Enum;
using System.ComponentModel.DataAnnotations;

namespace MVC_MechineText11.Dto
{
    public class RegisterDto
    {
        public string AgencyName { get; set; }
        public UserRole? Role { get; set; } = UserRole.Agency;
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
