using Microsoft.EntityFrameworkCore;

namespace ActivityJWT.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> users { get; set; }
    }
}
