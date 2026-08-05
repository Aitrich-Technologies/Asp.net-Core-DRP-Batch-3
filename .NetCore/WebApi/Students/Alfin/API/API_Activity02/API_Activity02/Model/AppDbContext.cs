using Microsoft.EntityFrameworkCore;

namespace API_Activity02.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)

              
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
