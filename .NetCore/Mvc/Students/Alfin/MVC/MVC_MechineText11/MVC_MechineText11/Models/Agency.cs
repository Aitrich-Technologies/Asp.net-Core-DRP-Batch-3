using Microsoft.AspNetCore.Identity;
using MVC_MechineText11.Enum;

namespace MVC_MechineText11.Models
{
    public class Agency
    {
        public Guid Id { get; set; }
        public string? AgencyName { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; } = UserRole.Agency;

    }
}
