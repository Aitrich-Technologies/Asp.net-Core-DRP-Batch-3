using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Workshop01.Models
{
    public class ParticipantInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public  Guid LeadId { get; set; }
        public Guid BookingId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Gender { get; set; }
        public DateOnly? Dob { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Citizenship { get; set; }
        public string? PassportNumber { get; set; }
        public DateOnly? IssueDate { get; set; }
        public DateOnly? ExpiryDate { get; set; }

        public string? PlaceOfBirth { get; set; }
        public DateTime CreatedAt { get; set; }
        public TourBookingForm Lead { get; set; }

    }
}
