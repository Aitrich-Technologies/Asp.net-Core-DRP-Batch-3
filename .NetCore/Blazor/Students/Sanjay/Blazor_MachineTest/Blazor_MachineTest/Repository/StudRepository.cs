using Blazor_MachineTest.Interface;
using Blazor_MachineTest.Model;
using Microsoft.EntityFrameworkCore;

namespace Blazor_MachineTest.Repository
{
    public class StudRepository : IStudRepository
    {
        public readonly AppDbContext _context;
        public StudRepository(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task AddAsync(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Student>> GetAllAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task UpdateAsync(Student student)
        {
            _context.Students.Update(student);
            await _context.SaveChangesAsync();
        }

        public async Task<Student> GetByIdAsync(int Id)
        {
            return await _context.Students.FindAsync(Id);
        }

        public async Task DeleteAsync(int studId)
        {
            var stud = await _context.Students.FindAsync(studId);
            if (stud != null)
            {
                _context.Students.Remove(stud);
                await _context.SaveChangesAsync();
            }
        }
    }
}
