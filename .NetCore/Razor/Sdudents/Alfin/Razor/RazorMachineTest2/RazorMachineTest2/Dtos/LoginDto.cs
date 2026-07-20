using System.ComponentModel.DataAnnotations;

namespace RazorMachineTest2.Dtos
{
    public class LoginDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        public int Password { get; set; }
    }
}
