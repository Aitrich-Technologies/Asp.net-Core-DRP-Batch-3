using System.ComponentModel.DataAnnotations;

namespace Workshop1.Dto
{
    public class LoginDto
    {
        public string UserName { get; set; }

        [Required, MaxLength(200)]
        public string Password { get; set; }
    }
}
