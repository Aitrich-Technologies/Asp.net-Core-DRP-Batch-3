using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCActivity02.Models;

namespace MVCActivity02.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _dbContext;

        public StudentController(AppDbContext dbContext)
        {
           _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddStudentViewModel viewModel)
        {
            var student = new Student
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
            };
            await _dbContext.students.AddAsync(student);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("List", "Student");

        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var student = await _dbContext.students.ToListAsync();
            return View(student);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var student = await _dbContext.students.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Student editStudent)
        {
            var student = await _dbContext.students.FindAsync(editStudent.Id);

            if (student != null)
            {
                student.Name = editStudent.Name;
                student.Email = editStudent.Email;
                student.Phone = editStudent.Phone;

                await _dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Student deleteStudent)
        {
            var student = await _dbContext.students.AsNoTracking().FirstOrDefaultAsync(x => x.Id == deleteStudent.Id);
            { 
             _dbContext.students.Remove(deleteStudent);
                await _dbContext.SaveChangesAsync();
            }
            return RedirectToAction("List", "Student");
        }
    }
}
