using Microsoft.EntityFrameworkCore;
namespace Exercise3.Models
{
    public class AppDbContext:DbContext
    {
         
        public AppDbContext(
            DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Destination> Destinations { get; set; }
    }
}

