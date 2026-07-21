using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorMachineTest2.Dtos;
using RazorMachineTest2.Interface;
using RazorMachineTest2.Service;

namespace RazorMachineTest2.Pages.Vehicles
{
    public class CreateModel : PageModel
    {
        

     private readonly IVehicleService _service;

    [BindProperty]
    public VehicleDto Vehicle { get; set; }

    public CreateModel(IVehicleService service)
    {
        _service = service;
    }

    public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await _service.AddVehicleAsync(Vehicle);
            return RedirectToPage("Index");
        }
    }
}
