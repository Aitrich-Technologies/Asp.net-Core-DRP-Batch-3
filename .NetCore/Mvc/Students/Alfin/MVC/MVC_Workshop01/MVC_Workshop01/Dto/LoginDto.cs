using System.ComponentModel.DataAnnotations;

namespace MVC_Workshop01.Dto
{
    public class LoginDto
    {
        public string UserName { get; set; }

        [Required, MaxLength(200)]
        public string Password { get; set; }
    }
}
