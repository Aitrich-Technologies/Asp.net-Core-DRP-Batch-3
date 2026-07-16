using Microsoft.EntityFrameworkCore;
namespace Login_Sample.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Auth> Users { get; set; }
    }
}
