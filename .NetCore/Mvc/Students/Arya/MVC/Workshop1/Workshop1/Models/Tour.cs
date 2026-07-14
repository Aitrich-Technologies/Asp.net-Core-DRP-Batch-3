using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Workshop1.Models
{
    [Index(nameof(ConsultantId), Name = "IX_Tours_ConsultantId")]
    [Index(nameof(CustomerId), Name = "IX_Tours_CustomerId")]
    [Index(nameof(DestinationId), Name = "IX_Tours_DestinationId")]
    public partial class Tour
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string TourName { get; set; } = null!;

        public string? TourDescription { get; set; }

        public Guid DestinationId { get; set; }

        public int? NoOfNights { get; set; }

        public int Price { get; set; }

        public DateOnly? DepartureDate { get; set; }

        public DateOnly? ArrivalDate { get; set; }

        public Guid? CustomerId { get; set; }

        public Guid ConsultantId { get; set; }

        public int Status { get; set; }

        // Navigation Property - Consultant
        [ForeignKey(nameof(ConsultantId))]
        [InverseProperty(nameof(User.TourConsultants))]
        public virtual User Consultant { get; set; } = null!;

        // Navigation Property - Customer
        [ForeignKey(nameof(CustomerId))]
        [InverseProperty(nameof(User.TourCustomers))]
        public virtual User? Customer { get; set; }

        // Navigation Property - Destination
        [ForeignKey(nameof(DestinationId))]
        [InverseProperty(nameof(Destination.Tours))]
        public virtual Destination Destination { get; set; } = null!;

        // One Tour can have many Booking Forms
        [InverseProperty(nameof(TourBookingForm.Tour))]
        public virtual ICollection<TourBookingForm> TourBookingForms { get; set; } = new List<TourBookingForm>();
    }
}