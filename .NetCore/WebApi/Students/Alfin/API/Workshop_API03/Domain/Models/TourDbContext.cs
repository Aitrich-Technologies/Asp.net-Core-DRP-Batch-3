using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public partial class TourDbContext : DbContext
    {
        public TourDbContext(DbContextOptions<TourDbContext> options)
           : base(options)
        {
        }
        public virtual DbSet<AuthUser> Users { get; set; }
        public virtual DbSet<Destination> Destinations { get; set; }

    }
}
