using MachineTest.Enum;

namespace MachineTest.Models
{
    public class AuthUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public UserRole? Role { get; set; } = UserRole.CUSTOMER;
        public string Password { get; set; }

    }
}
