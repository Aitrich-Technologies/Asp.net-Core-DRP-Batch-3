using Microsoft.EntityFrameworkCore;
namespace MVC_Workshop01.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TourBookingForm> TourBookingForm { get; set; }
        public DbSet<AuthUser> Users { get; set; }
        public DbSet<ParticipantInformation> participantInformation { get; set; }
    }
}
