using MachineTest.Interface;
using MachineTest.Model;
using System.Linq;

namespace MachineTest.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext context;

        public StudentRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(Student student)
        {
            context.students.Add(student);
            context.SaveChanges();
        }

        public Student GetUser(string studentName, string email)
        {
            return context.students.FirstOrDefault(x =>
                x.StudentName == studentName &&
                x.Email == email);
        }
    }
}