using AutoMapper;
using DiscoverMoldova.Core.Dtos;
using DiscoverMoldova.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverMoldova.Core.MappingProfiles
{
    public class LocationProfile : Profile
    {
        public LocationProfile()
        {
            CreateMap<Location, LocationDto>().ReverseMap();
            CreateMap<List<LocationDto>, List<Location>>().ReverseMap();
        }
    }
}
