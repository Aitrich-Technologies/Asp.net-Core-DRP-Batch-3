using System.ComponentModel.DataAnnotations;

namespace BlazorExercise2.Model
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        [Required]
        public string PasswordHash { get; set; }
    }
}
