using Microsoft.EntityFrameworkCore;

namespace StudentPortal.Models
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }
        
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-MN9T8T6;Initial Catalog=PartialView;Integrated Security=True;Trust Server Certificate=True");
    }
}
