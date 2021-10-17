using AutoMapper;
using DiscoverMoldova.Core.Dtos;
using DiscoverMoldova.Core.Dtos.Resort;
using DiscoverMoldova.Core.Exceptions;
using DiscoverMoldova.Core.Interfaces;
using DiscoverMoldova.Domain;
using DiscoverMoldova.Infrastructure.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverMoldova.Core.Services
{
    public class ResortService : IResortService
    {
        private readonly IRepository<Resort> _resortRepository;
        private readonly IRepository<ResortFacility> _resortFacilityRepository;
        private readonly IMapper _mapper;
        public ResortService(IRepository<Resort> resortRepository, IRepository<ResortFacility> resortFacilityRepository, IMapper mapper)
        {
            _resortRepository = resortRepository;
            _resortFacilityRepository = resortFacilityRepository;
            _mapper = mapper;
        }

        public async Task AddResortAsync(CreateResortDto resortDto)
        {
            var resort = _mapper.Map<Resort>(resortDto);
            await _resortRepository.AddAsync(resort);

            var resortFacilityList = resortDto.FacilitiesIds.Select(facilityId => new ResortFacility()
            {
                ResortId = resort.Id,
                FacilityId = facilityId
            }).ToArray();

            await _resortFacilityRepository.AddRangeAsync(resortFacilityList);
        }

        public async Task<ResortDto> GetResortByIdAsync(long id)
        {
            var resort = await _resortRepository.GetByIdAsync(id);

            if (resort == null)
            {
                throw new NotFoundException("Resort with such id does not exist");
            }

            return _mapper.Map<ResortDto>(resort);
        } 

        public List<ResortDto> GetAll()
        {
            IQueryable<Resort> resorts = _resortRepository.GetAll();

            var resortsDto = _mapper.Map<List<ResortDto>>(resorts);
            return resortsDto;
        }

        public async Task UpdateResortDetailsAsync(UpdateResortDto updateResortDto, long id)
        {
            var resort = await _resortRepository.GetByIdAsync(id);

            if (resort == null)
            {
                throw new NotFoundException("Resort with such id does not exist");
            }

            if (!string.IsNullOrWhiteSpace(updateResortDto.Name))
                resort.Name = updateResortDto.Name;

            if (!string.IsNullOrWhiteSpace(updateResortDto.Address))
                resort.Address = updateResortDto.Address;

            if (!string.IsNullOrWhiteSpace(updateResortDto.Email))
                resort.Email = updateResortDto.Email;

            if (!string.IsNullOrWhiteSpace(updateResortDto.Phone))
                resort.Phone = updateResortDto.Phone;

            if (updateResortDto.Price.HasValue)
                resort.Price = updateResortDto.Price.Value;

            if (updateResortDto.Capacity.HasValue)
                resort.Capacity = updateResortDto.Capacity.Value;

            if (!string.IsNullOrWhiteSpace(updateResortDto.Description))
                resort.Description = updateResortDto.Description;

            if (updateResortDto.LocationId.HasValue)
                resort.LocationId = updateResortDto.LocationId.Value;

            await _resortRepository.SaveAsync();
        }

        public async Task DeleteResortByIdAsync(long id)
        {
            await _resortRepository.DeleteAsync(id);
        }
    }
}
