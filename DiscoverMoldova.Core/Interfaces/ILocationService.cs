using DiscoverMoldova.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverMoldova.Core.Interfaces
{
    public interface ILocationService
    {
        List<DistrictDto> GetAllDistricts();
        List<LocationDto> GetLocationsByDistrictId(long id);
    }
}
