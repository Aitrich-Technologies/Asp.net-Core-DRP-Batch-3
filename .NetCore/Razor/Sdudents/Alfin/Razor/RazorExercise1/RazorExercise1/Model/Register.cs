
using System.ComponentModel.DataAnnotations;

namespace RazorExercise1.Model
{
    public class Register
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
