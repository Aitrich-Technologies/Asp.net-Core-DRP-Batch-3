using Microsoft.EntityFrameworkCore;

namespace Blazor_Exercise.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Users> Users { get; set; }
        public DbSet<Destinationn> Destinations { get; set; }
    }
}
