using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public partial class TourBookingDbContext : DbContext
    {
        public TourBookingDbContext(DbContextOptions<TourBookingDbContext> options)
           : base(options)
        {
        }

        public virtual DbSet<AuthUser> Users { get; set; }
        public virtual DbSet<Destination> Destinations { get; set; }

    }
}
