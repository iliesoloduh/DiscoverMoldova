using DiscoverMoldova.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscoverMoldova.API.Controllers
{
    [Route("api/districts")]
    [ApiController]
    [AllowAnonymous]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _locationService;
        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet]
        public IActionResult GetAllDistricts()
        {
            var districts = _locationService.GetAllDistricts();
            return Ok(districts);
        }

        [HttpGet("{id}/locations")]
        public IActionResult GetLocationsByDistrictId(long id)
        {
            var locations = _locationService.GetLocationsByDistrictId(id);
            return Ok(locations);
        }
    }
}
