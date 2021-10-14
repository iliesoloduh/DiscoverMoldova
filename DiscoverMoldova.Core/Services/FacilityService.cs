using AutoMapper;
using DiscoverMoldova.Core.Dtos;
using DiscoverMoldova.Core.Interfaces;
using DiscoverMoldova.Domain;
using DiscoverMoldova.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverMoldova.Core.Services
{
    public class FacilityService : IFacilityService
    {
        private readonly IRepository<Facility> _facilityRepository;
        private readonly IRepository<ResortFacility> _resortFacilityRepository;
        private readonly IMapper _mapper;

        public FacilityService(IRepository<Facility> facilityRepository, IRepository<ResortFacility> resortFacilityRepository, IMapper mapper)
        {
            _facilityRepository = facilityRepository;
            _resortFacilityRepository = resortFacilityRepository;
            _mapper = mapper;
        }

        public List<FacilityDto> GetAllFacilities()
        {
            IQueryable<Facility> facilities = _facilityRepository.GetAll().OrderBy(x => x.Name);

            var facilitiesDto = _mapper.Map<List<FacilityDto>>(facilities);
            return facilitiesDto;
        }

        public async Task<List<FacilityDto>> GetFacilitiesByResortIdAsync(long id)
        {
            List<Facility> facilities = await _resortFacilityRepository.GetAll().Where(x => x.ResortId == id).Select(x => x.Facility).ToListAsync();

            var facilitiesDto = _mapper.Map<List<FacilityDto>>(facilities);
            return facilitiesDto;
        }
    }
}
