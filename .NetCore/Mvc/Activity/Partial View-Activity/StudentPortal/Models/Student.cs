StudentPortal/Models/Student.cs
using System.ComponentModel.DataAnnotations;

namespace StudentPortal.Models;

public class Student
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [Range(0, 150)]
    public int Age { get; set; }

    [EmailAddress]
    public string? Email { get; set; }
}