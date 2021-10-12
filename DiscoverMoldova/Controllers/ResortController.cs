using DiscoverMoldova.Core.Dtos.Resort;
using DiscoverMoldova.Core.Exceptions;
using DiscoverMoldova.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscoverMoldova.API.Controllers
{
    [Route("api/resorts")]
    [ApiController]
    [Authorize]
    public class ResortController : ControllerBase
    {
        private readonly IResortService _resortService;
        private readonly IFacilityService _facilityService;
        public ResortController(IResortService resortService, IFacilityService facilityService)
        {
            _resortService = resortService;
            _facilityService = facilityService;
        }

        [HttpPost]
        public async Task<IActionResult> AddResort([FromBody] CreateResortDto resort)
        {
            await _resortService.AddResortAsync(resort);
            return Ok();
        }

        [HttpGet("{id}")]
        [ApiExceptionFilter]
        public async Task<IActionResult> GetResortById(long id)
        {
            var resort = await _resortService.GetResortByIdAsync(id);
            if (resort == null)
            {
                return NotFound("Resort with such id does not exist");
            }
            return Ok(resort);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var resorts = _resortService.GetAll();
            return Ok(resorts);
        }

        [HttpPatch("{id}")]
        [ApiExceptionFilter]
        public async Task<IActionResult> UpdateResortDetails([FromBody] UpdateResortDto updateResortDto, long id)
        {
            await _resortService.UpdateResortDetailsAsync(updateResortDto, id);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResort(long id)
        {
            await _resortService.DeleteResortByIdAsync(id);
            return NoContent();
        }

        [HttpGet("{id}/facilities")]
        public async Task<IActionResult> GetResortFacilities(long id)
        {
            var facilities = await _facilityService.GetFacilitiesByResortId(id);
            return Ok(facilities);
        }
    }
}
