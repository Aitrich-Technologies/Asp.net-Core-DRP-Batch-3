using MachineTest.Models;
using MachineTest.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MachineTest.Pages.Package
{
    public class DeleteModel : PageModel
    {
        private readonly PackageService _service;

        public DeleteModel(PackageService service)
        {
            _service = service;
        }

        [BindProperty]
        public Packages package { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            package = await _service.GetPackageByIdAsync(id);

            if (package == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            await _service.DeletePackageAsync(id);
            return RedirectToPage("Index");
        }
    }
}

