using Microsoft.EntityFrameworkCore;

namespace Exercise2.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AuthUser> AuthUsers { get; set; }

        public virtual DbSet<Destination> Destinations { get; set; }
    }
}
