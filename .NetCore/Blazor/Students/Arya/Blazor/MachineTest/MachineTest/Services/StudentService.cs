using MachineTest.Dto;
using MachineTest.Interface;
using MachineTest.Model;

namespace MachineTest.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public void Register(RegisterDto dto)
        {
            Student student = new Student
            {
                StudentName = dto.StudentName,
                Email = dto.Email,
                Course = dto.Course,
                Age = dto.Age
            };

            _repository.Add(student);
        }
    }
}