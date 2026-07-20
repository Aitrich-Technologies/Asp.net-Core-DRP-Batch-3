using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorMachineTest2.Interface;
using RazorMachineTest2.Models;
using RazorMachineTest2.Service;

namespace RazorMachineTest2.Pages.Vehicles
{
    public class EditModel : PageModel
    {
        private readonly IVehicleService _service;

        [BindProperty]
        public Vehicle Vehicle { get; set; }

        public EditModel(IVehicleService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var VehicleDto = await _service.GetVehicleByIdAsync(id);
            if (VehicleDto == null)
            {
                return NotFound();
            }

            Vehicle = VehicleDto;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.UpdateVehicleAsync(Vehicle.Id, Vehicle);
            return RedirectToPage("Index");
        }
    }
}
