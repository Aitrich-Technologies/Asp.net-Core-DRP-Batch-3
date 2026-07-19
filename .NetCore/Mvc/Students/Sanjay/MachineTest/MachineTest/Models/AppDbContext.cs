using Microsoft.EntityFrameworkCore;
namespace MachineTest.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Auth> Users { get; set; }
        public DbSet<Destination> Destinations { get; set; }
    }
}
