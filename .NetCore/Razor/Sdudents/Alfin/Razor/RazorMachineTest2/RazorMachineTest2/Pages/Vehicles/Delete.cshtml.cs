using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorMachineTest2.Interface;
using RazorMachineTest2.Models;
using RazorMachineTest2.Service;

namespace RazorMachineTest2.Pages.Vehicles
{
    public class DeleteModel : PageModel
    {
        private readonly IVehicleService _service;

        public DeleteModel(IVehicleService service)
        {
            _service = service;
        }

        [BindProperty]
        public Vehicle Vehicles { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Vehicles = await _service.GetVehicleByIdAsync(id);

            if (Vehicles == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            await _service.DeleteVehicleAsync(id);
            return RedirectToPage("Index");
        }
    }
}
