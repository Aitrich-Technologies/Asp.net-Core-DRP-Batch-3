using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

<<<<<<<< HEAD:.NetCore/Razor/Sdudents/Arya/Razor/Exercise3/Exercise3/Models/Destination.cs
namespace Exercise3.Models
========
namespace Blazor_Exercise.Models
>>>>>>>> 72d82c91693b9e35788e1e94f879a16858273e20:.NetCore/Blazor/Students/Sanjay/Blazor_Exercise/Blazor_Exercise/Models/Users.cs
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Email { get; set; }

        [Required]
<<<<<<<< HEAD:.NetCore/Razor/Sdudents/Arya/Razor/Exercise3/Exercise3/Models/Destination.cs
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }


        [Required]
        public string Location { get; set; }

        [Required]
        public int Duration { get; set; }

        public string? ImagePath { get; set; }
========
        public string PasswordHash { get; set; }
>>>>>>>> 72d82c91693b9e35788e1e94f879a16858273e20:.NetCore/Blazor/Students/Sanjay/Blazor_Exercise/Blazor_Exercise/Models/Users.cs
    }
}
