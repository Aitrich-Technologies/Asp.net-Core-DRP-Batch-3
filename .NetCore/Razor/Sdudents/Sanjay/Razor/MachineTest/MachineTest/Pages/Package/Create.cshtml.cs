using MachineTest.Dto;
using MachineTest.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MachineTest.Pages.Package
{
    public class CreateModel : PageModel
    {
        private readonly PackageService _service;

        [BindProperty]
        public PackageDto package { get; set; }

        public CreateModel(PackageService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await _service.AddPackageAsync(package);
            return RedirectToPage("Index");
        }
    }
}
