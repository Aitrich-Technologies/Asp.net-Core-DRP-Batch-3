using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Workshop_Razor.Dto;
using Workshop_Razor.Service;

namespace Workshop_Razor.Pages.Tour
{
    public class CreateModel : PageModel
    {
            private readonly TourService _service;

            [BindProperty]
            public TourDto TourPost { get; set; }

            public CreateModel(TourService service)
            {
                _service = service;
            }

            public async Task<IActionResult> OnPostAsync()
            {
                if (!ModelState.IsValid)
                    return Page();

                await _service.AddTourAsync(TourPost);
                return RedirectToPage("Index");
            }
        }
    
}
