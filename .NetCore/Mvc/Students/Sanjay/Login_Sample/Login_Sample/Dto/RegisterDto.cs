using Login_Sample.Enum;
using System.ComponentModel.DataAnnotations;

namespace Login_Sample.Dto
{
    public class RegisterDto

    {
        [Required]
        public string UserName { get; set; }

        public string? Role { get; set; }

        [MaxLength(20)]
        public string TelephoneNo { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
