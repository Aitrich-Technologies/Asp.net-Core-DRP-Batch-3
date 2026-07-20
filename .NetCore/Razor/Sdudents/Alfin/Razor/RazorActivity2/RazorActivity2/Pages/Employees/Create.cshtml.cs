using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorActivity2.Models;

namespace RazorActivity2.Pages.Employees
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _context;

        [BindProperty]
        public Employee Employee { get; set; }

        public CreateModel(AppDbContext context)
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
