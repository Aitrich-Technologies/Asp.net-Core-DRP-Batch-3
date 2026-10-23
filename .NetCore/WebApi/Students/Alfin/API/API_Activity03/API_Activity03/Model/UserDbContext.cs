using Microsoft.EntityFrameworkCore;

namespace API_Activity03.Model
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> users { get; set; }
    }
}
