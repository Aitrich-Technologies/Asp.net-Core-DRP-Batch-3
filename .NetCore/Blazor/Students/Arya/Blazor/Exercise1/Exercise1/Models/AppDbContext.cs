using Microsoft.EntityFrameworkCore;
namespace Exercise1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Tour> Tours { get; set; }

        
    }
}
