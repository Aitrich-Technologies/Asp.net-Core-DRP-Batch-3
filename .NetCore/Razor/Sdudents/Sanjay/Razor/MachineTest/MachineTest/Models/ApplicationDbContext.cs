using Microsoft.EntityFrameworkCore;
namespace MachineTest.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Packages> Packages { get; set; }

        public DbSet<User> Users { get; set; }

    }
}
