using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MVC_Exercise01.Dto;
using MVC_Exercise01.Interface;

namespace MVC_Exercise01.Controllers
{
    public class DestinationController : Controller
    {
         private readonly IDestinationService _Service;
        private readonly IMapper _Mapper;
        public DestinationController(IDestinationService service, IMapper mapper)
        {
            _Service = service;
            _Mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        { 
         var list = await _Service.GetAllAsync();
            return View(list);
        }
        public IActionResult Create()
        {
            return View(new DestinationDto());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DestinationDto dto)
        { 
         if (!ModelState.IsValid) return View(dto);

         var created = await _Service.CreateAsync(dto);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var existing = await _Service.GetByIdAsync(id);
            if (existing == null) return NotFound();
            var dto = _Mapper.Map<DestinationDto>(existing);
            return View(dto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, DestinationDto dto)
        {
            if (!ModelState.IsValid) return View(dto);

            var updated = await _Service.UpdateAsync(id, dto);
            if (updated ==null) return NotFound();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        { 
         var item = await _Service.GetByIdAsync(id); 
            if (item == null) return NotFound();
            return View(item);

        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var destination = await _Service.GetByIdAsync(id);

            if (destination == null)
                return NotFound();

            return View(destination);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var deleted = await _Service.DeleteAsync(id);

            if (!deleted)
                return NotFound();

            return RedirectToAction(nameof(Index));
        }
    }
}
