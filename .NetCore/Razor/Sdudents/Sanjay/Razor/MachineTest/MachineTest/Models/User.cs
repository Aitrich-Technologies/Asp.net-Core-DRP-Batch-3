using System.ComponentModel.DataAnnotations;

namespace MachineTest.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
