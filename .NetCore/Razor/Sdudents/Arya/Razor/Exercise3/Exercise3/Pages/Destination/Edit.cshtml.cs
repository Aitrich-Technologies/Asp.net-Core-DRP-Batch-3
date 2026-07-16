using Exercise3.Dto;
using Exercise3.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercise3.Pages.Destination
{
    public class EditModel : PageModel
    {
        private readonly IDestinationService _service;

        public EditModel(IDestinationService service)
        {
            _service = service;
        }

        [BindProperty]
        public DestinationDto Destination { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Destination = await _service.GetById(id);

            if (Destination == null)
            {
                return RedirectToPage("./Index");
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.Update(Destination);

            return RedirectToPage("./Index");
        }
    }
}