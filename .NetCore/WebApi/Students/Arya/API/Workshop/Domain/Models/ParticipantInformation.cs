using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    public class ParticipantInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public Guid Id { get; set; }

        public Guid LeadId { get; set; }
        public Guid BookingId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Gender { get; set; }
        public DateOnly? Dob { get; set; }
        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }
        public string? Citizenship { get; set; }
        public string? PassportNumber { get; set; }
        public DateOnly? IssueDate { get; set; }
        public DateOnly? ExpiryDate { get; set; }
        public string? PlaceOfBirth { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        // Navigation
        public TourBookingForm Lead { get; set; } = null!;
    }
}
