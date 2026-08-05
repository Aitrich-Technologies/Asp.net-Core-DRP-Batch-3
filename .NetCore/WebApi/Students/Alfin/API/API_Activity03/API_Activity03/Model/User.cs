using API_Activity03.Enum;

namespace API_Activity03.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
        public int IsActive { get; set; } = 1;
        public bool IsEmailVerified { get; set; } = false;

        public string? VerificationToken { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
