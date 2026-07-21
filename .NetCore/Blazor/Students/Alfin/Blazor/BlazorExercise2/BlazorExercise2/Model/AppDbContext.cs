using Microsoft.EntityFrameworkCore;

namespace BlazorExercise2.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Users> Users { get; set; }
        public DbSet<Destination> Destinations { get; set; }
    }
}
