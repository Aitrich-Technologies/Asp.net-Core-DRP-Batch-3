using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public partial class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {
        }

        public virtual DbSet<AuthUser> Users { get; set; }
        public virtual DbSet<Destination> Destinations { get; set; }
        public virtual DbSet<ParticipantInformation> ParticipantInformations { get; set; }
        public virtual DbSet<TermsAndConditions> TermsAndConditions { get; set; }
        public virtual DbSet<Tours> Tours { get; set; }
        public virtual DbSet<Notes> Notes { get; set; }
        public virtual DbSet<TourBookingForm> TourBookingForms { get; set; }
    }
}
