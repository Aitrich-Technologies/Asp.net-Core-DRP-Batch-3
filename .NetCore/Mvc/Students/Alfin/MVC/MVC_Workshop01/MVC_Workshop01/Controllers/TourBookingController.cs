using Microsoft.AspNetCore.Mvc;
using MVC_Workshop01.Dto;
using MVC_Workshop01.Interface;

namespace MVC_Workshop01.Controllers
{
    public class TourBookingController : Controller
    {
        private readonly ITourBookingService _service;

        public TourBookingController(ITourBookingService service)
        {
            _service = service;
        }

       
        private (string userId, string role) GetSession()
        {
            return (
                HttpContext.Session.GetString("UserId"),
                HttpContext.Session.GetString("Role")
            );
        }


        public async Task<IActionResult> Index()
        {
            var (userId, role) = GetSession();

            if (string.IsNullOrEmpty(userId))
                return RedirectToAction("Login");

            if (role != "AGENCY" && role != "CONSULTANT" && role != "CUSTOMER")
                return RedirectToAction("AccessDenied");

            var result = await _service.GetAllBookingAsync();
            return View(result);
        }


        public IActionResult Create(Guid Id)
        {
            var (userId, role) = GetSession();

            if (string.IsNullOrEmpty(userId))
                return RedirectToAction("Login", "Auth");

            if (role != "AGENCY" && role != "CUSTOMER" && role != "CONSULTANT")
                return RedirectToAction("AccessDenied");
            //var model = new CreateBookingDto
            //{
            //    TourId = Id
            //};

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateBookingDto dto, Guid Id)
        {
            var (userId, role) = GetSession();

            if (string.IsNullOrEmpty(userId))
                return RedirectToAction("Login", "Auth");

            if (role != "AGENCY" && role != "CUSTOMER" && role != "CONSULTANT")
                return RedirectToAction("AccessDenied");

            Guid parsedUserId = Guid.Parse(userId);

            //var alreadyBooked = await _service.IsAlreadyBooked(parsedUserId);

            //if (alreadyBooked)
            //{
            //    TempData["Error"] = "User has already booked this tour.";
            //    return RedirectToAction("Create", new { id = Id });
            //}

            dto.UserId = parsedUserId;

            var booking = await _service.CreateAsync(dto, Id);

            return RedirectToAction("Index", new { id = booking.Id });
        }


        [HttpGet]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(Guid id)
        {
            var (userId, role) = GetSession();

            if (string.IsNullOrEmpty(userId))
                return RedirectToAction("Login");

          
            var booking = await _service.GetByIdAsync(id);

            if (booking == null)
                return NotFound();

            //var bookings = await _service.GetByIdBookingAsync(booking.Id);

            var viewModel = new TourDetailsDto
            {
                //Tour = tour,
                Booking = booking
            };

            return View(viewModel);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var booking = await _service.GetByIdAsync(id);

            if (booking == null)
                return NotFound();

            return View(booking);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(TourBookingDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }

            await _service.UpdateAsync(dto);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var booking = await _service.GetByIdAsync(id);

            if (booking == null)
                return NotFound();

            return View(booking);
        }

        
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }





        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}

