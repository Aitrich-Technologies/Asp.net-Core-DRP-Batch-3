using MachineTest.Models;
using MachineTest.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MachineTest.Pages.Package
{
    public class EditModel : PageModel
    {
        private readonly PackageService _service;

        [BindProperty]
        public Packages package { get; set; }

        public EditModel(PackageService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var packageDto = await _service.GetPackageByIdAsync(id);
            if (packageDto == null)
            {
                return NotFound();
            }

            package = packageDto;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            await _service.UpdatePackageAsync(package.Id, package);
            return RedirectToPage("Index");
        }
    }
}
