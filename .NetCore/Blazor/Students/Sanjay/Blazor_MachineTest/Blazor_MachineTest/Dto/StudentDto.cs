using System.ComponentModel.DataAnnotations;

namespace Blazor_MachineTest.Dto
{
    public class StudentDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Course { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
