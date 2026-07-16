using MachineTest.Enum;
using System.ComponentModel.DataAnnotations;

namespace MachineTest.Dto
{
    public class AuthUserDto
    {
        public string Name { get; set; }
        public UserRole? Role { get; set; } = UserRole.CUSTOMER;
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
