using Login_Sample.Enum;
using System.ComponentModel.DataAnnotations;

namespace Login_Sample.Models
{
    public class Auth
    {
        public Guid Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public UserRole? Role { get; set; } = UserRole.Admin;

        [MaxLength(20)]
        public string TelephoneNo { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
