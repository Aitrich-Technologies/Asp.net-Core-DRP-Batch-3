using Microsoft.EntityFrameworkCore;

namespace BlazorMachineText.Model
{
    public class AppDbContext :DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Login> Login { get; set; }
    }
}
