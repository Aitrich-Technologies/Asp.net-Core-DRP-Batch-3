using Microsoft.EntityFrameworkCore;

namespace RazorExercise1.Model
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) :base(options) { }
        public DbSet<Consultants>Consultants { get; set; }
        public DbSet<Register> Registers { get; set; }
    }
}
