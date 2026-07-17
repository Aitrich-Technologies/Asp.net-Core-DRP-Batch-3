using Exercise3.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercise3.Pages.Destination
{
    public class DeleteModel : PageModel
    {
        private readonly IDestinationService _service;

        public DeleteModel(IDestinationService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            await _service.Delete(id);

            return RedirectToPage("./Index");
        }
    }
}
