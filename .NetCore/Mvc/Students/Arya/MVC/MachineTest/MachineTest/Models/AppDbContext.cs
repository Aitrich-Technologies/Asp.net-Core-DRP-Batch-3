using Microsoft.EntityFrameworkCore;
namespace MachineTest.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {
        }
        public  DbSet<AuthUser> AuthUsers { get; set; }

        public DbSet<Tour> Tours { get; set; }
        public  DbSet<Booking> Bookings { get; set; }

    }
}
