using MachineTest.DTOs;
using MachineTest.Interface;
using MachineTest.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MachineTest.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
        public class TourController : ControllerBase
        {
            private readonly ITourService _tourService;

            public TourController(ITourService tourService)
            {
                _tourService = tourService;
            }

            [HttpPost]
            [Authorize]
            public async Task<IActionResult> Add([FromBody] TourCreateDto dto)
            {
                var userIdValue = User.FindFirst("UserId")?.Value;

                if (!Guid.TryParse(userIdValue, out var userId))
                {
                return Unauthorized("Valid user ID was not found in the token.");
                    
                }

                var result = await _tourService.AddAsync(dto, userId);

                return CreatedAtAction(
                    nameof(GetById),
                    new { id = result.Id },
                    result);
            }

            
            [HttpGet]
            public async Task<IActionResult> GetAll()
            {
                var tours = await _tourService.GetAllAsync();

                return Ok(tours);
            }

            [HttpGet("{id:guid}")]
            public async Task<IActionResult> GetById(Guid id)
            {
                var tour = await _tourService.GetByIdAsync(id);

                if (tour == null)
                {
                return NotFound("Tour not found.");
                 
                }

                return Ok(tour);
            }
        }
   
}
