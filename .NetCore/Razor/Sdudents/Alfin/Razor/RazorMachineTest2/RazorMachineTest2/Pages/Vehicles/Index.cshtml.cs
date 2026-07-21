using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorMachineTest2.Interface;
using RazorMachineTest2.Models;
using RazorMachineTest2.Service;

namespace RazorMachineTest2.Pages.Vehicles
{
    public class IndexModel : PageModel
    {
        private readonly IVehicleService _service;
        public List<Vehicle> Vehicle { get; set; }

        public IndexModel(IVehicleService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            Vehicle = await _service.GetAllVehicleAsync();
        }
    }
}
