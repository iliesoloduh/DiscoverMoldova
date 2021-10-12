using AutoMapper;
using DiscoverMoldova.Core.Dtos;
using DiscoverMoldova.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverMoldova.Core.MappingProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<CreateUserDto, User>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<List<UserDto>, List<User>>().ReverseMap();
            CreateMap<UpdateUserDto, User>().ReverseMap();
        }
    }
}
