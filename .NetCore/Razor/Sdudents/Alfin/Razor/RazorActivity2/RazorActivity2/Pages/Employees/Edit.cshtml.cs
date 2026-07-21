using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorActivity2.Models;

namespace RazorActivity2.Pages.Employees
{
    public class EditModel : PageModel
    {
        private readonly AppDbContext _context;

        public EditModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Employee = await _context.Employees.FindAsync(id);

            if (Employee == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var employeeToUpdate = await _context.Employees.FindAsync(Employee.Id);

            if (employeeToUpdate == null)
            {
                return NotFound();
            }

 
            employeeToUpdate.Name = Employee.Name;
            employeeToUpdate.Position = Employee.Position;
            employeeToUpdate.Salary = Employee.Salary;
            employeeToUpdate.Department = Employee.Department;

            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
