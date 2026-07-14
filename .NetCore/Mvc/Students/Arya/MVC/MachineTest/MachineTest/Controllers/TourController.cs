using MachineTest.Dto;
using MachineTest.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MachineTest.Controllers
{
    public class TourController : Controller
    {
        private readonly ITourService _tourService;

        public TourController(ITourService tourService)
        {
            _tourService = tourService;
        }

        public async Task<IActionResult> Index()
        {
            var tours = await _tourService.GetAllToursAsync();
            return View(tours);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TourDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            await _tourService.AddTourAsync(dto);

            return RedirectToAction(nameof(Index));
        }
    }
}