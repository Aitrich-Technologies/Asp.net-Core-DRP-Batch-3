using Microsoft.EntityFrameworkCore;

namespace Workshop.Models
{
    public class DestinationDbContext : DbContext
    {
        public DestinationDbContext(DbContextOptions<DestinationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AuthUser> AuthUsers { get; set; }

        public virtual DbSet<Destination> Destinations { get; set; }

    }
}
