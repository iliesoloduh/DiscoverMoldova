using DiscoverMoldova.Core.Dtos;
using DiscoverMoldova.Core.Dtos.Resort;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverMoldova.Core.Interfaces
{
    public interface IResortService
    {
        Task AddResortAsync(CreateResortDto resort);
        Task<ResortDto> GetResortByIdAsync(long id);
        List<ResortDto> GetAll();
        Task UpdateResortDetailsAsync(UpdateResortDto resort, long id);
        Task DeleteResortByIdAsync(long id);
    }
}
