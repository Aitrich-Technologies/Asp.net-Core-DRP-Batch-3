using MachineTest.Model;

namespace MachineTest.Interface
{
    public interface IStudentRepository
    {
        void Add(Student student);
        Student GetUser(string StudentName, string Password);
    }
}
