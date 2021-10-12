using AutoMapper;
using DiscoverMoldova.Core.Dtos;
using DiscoverMoldova.Core.Dtos.Resort;
using DiscoverMoldova.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverMoldova.Core.MappingProfiles
{
    public class ResortProfile : Profile
    {
        public ResortProfile() 
        {
            CreateMap<Resort, ResortDto>().ReverseMap();
            CreateMap<CreateResortDto, Resort>().ReverseMap();
            CreateMap<List<ResortDto>, List<Resort>>().ReverseMap();
            CreateMap<UpdateResortDto, Resort>().ReverseMap();
        }
    }
}
