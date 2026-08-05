using Microsoft.EntityFrameworkCore;

namespace MVCActivity01.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { }
        public DbSet<User> Users { get; set; }
    }
}
