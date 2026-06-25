using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Activity3.Models;

namespace Razor_Activity3.Pages.Employees
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public Employee Employee { get; set; }

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Employees.Add(Employee);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
