using DiscoverMoldova.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscoverMoldova.API.Controllers
{
    [Route("api/facilities")]
    [ApiController]
    public class FacilityController : ControllerBase
    {
        private readonly IFacilityService _facilityService;
        public FacilityController(IFacilityService facilityService)
        {
            _facilityService = facilityService;
        }

        [HttpGet]
        public IActionResult GetAllFacilities()
        {
            var facilities = _facilityService.GetAllFacilities();
            return Ok(facilities);
        }
    }
}
