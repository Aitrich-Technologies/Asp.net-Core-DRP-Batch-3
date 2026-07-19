using System.ComponentModel.DataAnnotations;

namespace TourManagement.Dto
{
    public class LoginDto
    {
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
