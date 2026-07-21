using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorExercise1.Model;

namespace RazorExercise1.Pages.Consultant
{
    public class viewModel : PageModel
    {
        private readonly AppDbContext _context;

        public viewModel(AppDbContext context)
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
