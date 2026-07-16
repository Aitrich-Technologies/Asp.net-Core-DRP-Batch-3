using System.ComponentModel.DataAnnotations;

namespace MachineTest.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string StudentName { get; set; }

       
        [Required]
        public string Course { get; set; }

        [Required]
        public int Age { get; set; }
    }
}