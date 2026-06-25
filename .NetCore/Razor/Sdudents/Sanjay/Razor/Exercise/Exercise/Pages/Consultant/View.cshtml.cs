using Exercise.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercise.Pages.Consultant
{
    public class ViewModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ViewModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Consultants? ConsultantInfo { get; set; }

        public IActionResult OnGet(int id)
        {
            ConsultantInfo = _context.Consultants
                                     .FirstOrDefault(c => c.Id == id);

            if (ConsultantInfo == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
