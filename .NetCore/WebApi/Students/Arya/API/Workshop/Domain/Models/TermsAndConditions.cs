using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public partial class TermsAndConditions
    {
        public Guid Id { get; set; }

        public Guid TourId { get; set; }

        public string? Terms { get; set; }

        public virtual Tours Tour { get; set; } = null!;
    }
}
