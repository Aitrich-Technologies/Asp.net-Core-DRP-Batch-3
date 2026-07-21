using Microsoft.AspNetCore.Identity;
using RazorWorkshop2.Enum;

namespace RazorWorkshop2.Models
{
    public class User
    {
       

        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Gender { get; set; }

        public DateOnly? Dob { get; set; }

        public UserRole Role { get; set; }

        public DateOnly? DateOfBirth { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string? EmailId { get; set; }

        public string? TelePhoneNo { get; set; }
    }
}
