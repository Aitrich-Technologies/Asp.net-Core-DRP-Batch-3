using Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public partial class TourBookingForm
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid TourId { get; set; }

        public Guid? UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        [MaxLength(10)]
        public string? Gender { get; set; }

        public DateOnly? Dob { get; set; }

        [MaxLength(50)]
        public string? Citizenship { get; set; }

        [MaxLength(30)]
        public string? PassportNumber { get; set; }

        public DateOnly? IssueDate { get; set; }

        public DateOnly? ExpiryDate { get; set; }

        [MaxLength(100)]
        public string? PlaceOfBirth { get; set; }

        public bool LeadPassenger { get; set; }

        public ParticipantType ParticipantType { get; set; }

        public TourStatus Status { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [ForeignKey(nameof(TourId))]
        public virtual Tours Tour { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public virtual AuthUser? User { get; set; }

        public virtual ICollection<ParticipantInformation> ParticipantInformations { get; set; }
            = new List<ParticipantInformation>();
    }
}