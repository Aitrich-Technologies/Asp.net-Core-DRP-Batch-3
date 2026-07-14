using System.ComponentModel.DataAnnotations.Schema;

namespace Workshop1.Models
{
    public partial class TourBookingForm
    {
        public Guid Id { get; set; }

        public Guid TourId { get; set; }

        public Guid? UserId { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string? Gender { get; set; }

        public DateOnly? Dob { get; set; }

        public string? Citizenship { get; set; }

        public string? PassportNumber { get; set; }

        public DateOnly? IssueDate { get; set; }

        public DateOnly? ExpiryDate { get; set; }

        public string? PlaceOfBirth { get; set; }

        public bool? LeadPassenger { get; set; }

        public DateTime CreatedAt { get; set; }

        public int ParticipantType { get; set; }

        public int Status { get; set; }

        [InverseProperty("Lead")]
        public virtual ICollection<ParticipantInformation> ParticipantInformations { get; set; } = new List<ParticipantInformation>();

        [ForeignKey("TourId")]
        [InverseProperty("TourBookingForms")]
        public virtual Tour Tour { get; set; } = null!;

        [ForeignKey("UserId")]
        [InverseProperty("TourBookingForms")]
        public virtual User? User { get; set; }
    }
}
