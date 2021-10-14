using DiscoverMoldova.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverMoldova.Core.Interfaces
{
    public interface IFacilityService
    {
        List<FacilityDto> GetAllFacilities();
        Task<List<FacilityDto>> GetFacilitiesByResortIdAsync(long id);
    }
}
