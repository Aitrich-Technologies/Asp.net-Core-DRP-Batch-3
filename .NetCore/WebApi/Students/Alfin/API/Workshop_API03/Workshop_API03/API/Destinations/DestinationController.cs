using Domain.Services.Destinations.DTO;
using Domain.Services.Destinations.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Workshop_API03.Controllers;

namespace Workshop_API03.API.Destinations
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DestinationController : BaseApiController<DestinationController>
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }


        [Authorize(Roles = "AGENCY,CUSTOMER,CONSULTANT")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var destinations = await _destinationService.GetAllAsync();
            return Ok(destinations);
        }


        [Authorize(Roles = "AGENCY,CUSTOMER,CONSULTANT")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var destination = await _destinationService.GetByIdAsync(id);
            if (destination == null)
                return NotFound();
            return Ok(destination);
        }


        [Authorize(Roles = "AGENCY,CUSTOMER,CONSULTANT")]
        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create([FromForm] DestinationDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdDestination = await _destinationService.AddAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = createdDestination.Id }, createdDestination);
        }


        [Authorize(Roles = "AGENCY,CUSTOMER,CONSULTANT")]
        [HttpPut("{id}")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Update(Guid id, [FromForm] DestinationUpdateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var updated = await _destinationService.UpdateAsync(id, dto);
            if (!updated)
                return NotFound();

            return NoContent();
        }


        [Authorize(Roles = "AGENCY,CUSTOMER,CONSULTANT")]
        [HttpPatch("{id}")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Patch(Guid id, [FromForm] DestinationPatchDto dto)
        {
            var patched = await _destinationService.PatchAsync(id, dto);
            if (!patched)
                return NotFound();

            return NoContent();
        }

        [Authorize(Roles = "AGENCY,CUSTOMER,CONSULTANT")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var deleted = await _destinationService.DeleteAsync(id);
            if (!deleted)
                return NotFound();

            return NoContent();
        }

    }
}
