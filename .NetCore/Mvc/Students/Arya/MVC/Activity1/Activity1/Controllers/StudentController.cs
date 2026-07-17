using Activity1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Activity1.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext dbContext;

        public StudentController(AppDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        // Display Add Page
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        // Save Student
        [HttpPost]
        public async Task<IActionResult> Add(AddStudentViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var student = new Student
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Phone = viewModel.Phone
            };

            await dbContext.Students.AddAsync(student);
            await dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(List));
        }

        // Display Students
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var students = await dbContext.Students.ToListAsync();
            return View(students);
        }

        // Display Edit Page
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var student = await dbContext.Students.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // Update Student
        [HttpPost]
        public async Task<IActionResult> Edit(Student editStudent)
        {
            if (!ModelState.IsValid)
            {
                return View(editStudent);
            }

            var student = await dbContext.Students.FindAsync(editStudent.Id);

            if (student != null)
            {
                student.Name = editStudent.Name;
                student.Email = editStudent.Email;
                student.Phone = editStudent.Phone;

                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction(nameof(List));
        }

        // Delete Student
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var student = await dbContext.Students.FindAsync(id);

            if (student != null)
            {
                dbContext.Students.Remove(student);
                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction(nameof(List));
        }
    }
}