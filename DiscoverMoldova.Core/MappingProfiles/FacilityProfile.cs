using AutoMapper;
using DiscoverMoldova.Core.Dtos;
using DiscoverMoldova.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverMoldova.Core.MappingProfiles
{
    public class FacilityProfile : Profile
    {
        public FacilityProfile()
        {
            CreateMap<Facility, FacilityDto>().ReverseMap();
            CreateMap<List<FacilityDto>, List<Facility>>().ReverseMap();
        }
    }
}
