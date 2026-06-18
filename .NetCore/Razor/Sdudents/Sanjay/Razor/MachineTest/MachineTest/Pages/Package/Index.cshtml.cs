using MachineTest.Models;
using MachineTest.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MachineTest.Pages.Package
{
    public class IndexModel : PageModel
    {
        private readonly PackageService _service;
        public List<Packages> packages { get; set; }

        public IndexModel(PackageService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            packages = await _service.GetAllPackageAsync();
        }
    }
}
