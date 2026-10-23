using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public partial class Notes
    {
        public Guid Id { get; set; }
        public Guid TourId { get; set; }

        public string? TourNotes { get; set; }
        public NotesStatus Status { get; set; }

        public virtual Tourss Tour { get; set; } = null!;
    }
}
