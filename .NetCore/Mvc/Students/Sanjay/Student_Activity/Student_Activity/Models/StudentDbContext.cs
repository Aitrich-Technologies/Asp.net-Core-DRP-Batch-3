using Microsoft.EntityFrameworkCore;

namespace Student_Activity.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=Sanjay2007;Initial Catalog=Student_MVC;Integrated Security=True;Trust Server Certificate=True");
    }
}
