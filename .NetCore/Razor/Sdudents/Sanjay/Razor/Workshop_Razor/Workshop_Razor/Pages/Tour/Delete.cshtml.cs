using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Workshop_Razor.Models;
using Workshop_Razor.Dto;
using Workshop_Razor.Service;

namespace Workshop_Razor.Pages.Tour
{
    public class DeleteModel : PageModel
    {
        private readonly TourService _service;

        public DeleteModel(TourService service)
        {
            _service = service;
        }

        [BindProperty]
        public Tours TourPost { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            TourPost = await _service.GetTourByIdAsync(id);

            if (TourPost == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            await _service.DeleteTourAsync(id);
            return RedirectToPage("Index");
        }
    }
}
