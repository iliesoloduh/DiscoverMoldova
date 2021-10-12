using AutoMapper;
using DiscoverMoldova.Core.Dtos;
using DiscoverMoldova.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverMoldova.Core.MappingProfiles
{
    public class DistrictProfile : Profile
    {
        public DistrictProfile()
        {
            CreateMap<District, DistrictDto>().ReverseMap();
            CreateMap<List<DistrictDto>, List<District>>().ReverseMap();
        }
    }
}
