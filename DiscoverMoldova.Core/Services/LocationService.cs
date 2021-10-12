using AutoMapper;
using DiscoverMoldova.Core.Dtos;
using DiscoverMoldova.Core.Interfaces;
using DiscoverMoldova.Domain;
using DiscoverMoldova.Infrastructure.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscoverMoldova.Core.Services
{
    public class LocationService : ILocationService
    {
        private readonly IRepository<Location> _locationRepository;
        private readonly IRepository<District> _districtRepository;
        private readonly IMapper _mapper;

        public LocationService(IRepository<Location> locationRepository, IRepository<District> districtRepository, IMapper mapper)
        {
            _locationRepository = locationRepository;
            _districtRepository = districtRepository;
            _mapper = mapper;
        }

        public List<DistrictDto> GetAllDistricts()
        {
            IQueryable<District> districts = _districtRepository.GetAll().OrderBy(x => x.Name);

            var districtsDto = _mapper.Map<List<DistrictDto>>(districts);
            return districtsDto;
        }

        public List<LocationDto> GetLocationsByDistrictId(long id)
        {
            IQueryable<Location> locations = _locationRepository.GetAll().Where(e => e.DistrictId == id).OrderBy(e => e.Name);
            
            var locationsDto = _mapper.Map<List<LocationDto>>(locations);
            return locationsDto;
        }
    }
}
