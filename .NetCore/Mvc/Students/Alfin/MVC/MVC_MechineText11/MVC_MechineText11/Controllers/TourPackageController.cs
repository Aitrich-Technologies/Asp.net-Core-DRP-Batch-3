using Microsoft.AspNetCore.Mvc;
using MVC_MechineText11.Dto;
using MVC_MechineText11.Interface;

namespace MVC_MechineText11.Controllers
{
    public class TourPackageController : Controller
    {
        private readonly ITourPackageService _service;

        public TourPackageController(ITourPackageService service)
        {
            _service = service;
        }


        public async Task<IActionResult> Index()
        {
            var packages = await _service.GetAllAsync();
            return View(packages);
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var package = await _service.GetByIdAsync(id);

            if (package == null)
            {
                return NotFound();
            }

            return View(package);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TourPackageDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            var userIdClaim = User.FindFirst("UserId");

            if (userIdClaim == null)
                return Unauthorized();

            Guid agencyId = Guid.Parse(userIdClaim.Value);


            dto.AgencyId = agencyId;

            await _service.CreateAsync(dto, agencyId);

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var package = await _service.GetByIdAsync(id);

            if (package == null)
                return NotFound();

            return View(package);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(TourPackageDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            var userIdClaim = User.FindFirst("UserId");

            if (userIdClaim == null)
                return Unauthorized();


            dto.AgencyId = Guid.Parse(userIdClaim.Value);

            await _service.UpdateAsync(dto);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var package = await _service.GetByIdAsync(id);

            if (package == null)
                return NotFound();

            return View(package);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
