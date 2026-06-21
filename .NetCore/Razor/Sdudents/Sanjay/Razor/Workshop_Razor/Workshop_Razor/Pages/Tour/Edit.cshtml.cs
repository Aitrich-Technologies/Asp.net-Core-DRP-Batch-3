using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Workshop_Razor.Dto;
using Workshop_Razor.Models;
using Workshop_Razor.Service;

namespace Workshop_Razor.Pages.Tour
{
    public class EditModel : PageModel
    {
        private readonly TourService _service;

        [BindProperty]
        public Tours TourPost { get; set; }

        public EditModel(TourService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var tourDto = await _service.GetTourByIdAsync(id);
            if (tourDto == null)
            {
                return NotFound();
            }

            TourPost = tourDto;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            await _service.UpdateTourAsync(TourPost.Id, TourPost);
            return RedirectToPage("Index");
        }
    }
}
