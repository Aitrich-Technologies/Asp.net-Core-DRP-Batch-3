using Microsoft.EntityFrameworkCore;

namespace RazorMachineTest2.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }

    }
}
