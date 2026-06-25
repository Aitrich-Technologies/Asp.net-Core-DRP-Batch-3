using System.ComponentModel.DataAnnotations;

namespace MachineTest.Dto
{
    public class UserDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
