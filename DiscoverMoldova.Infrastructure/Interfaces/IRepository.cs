using DiscoverMoldova.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverMoldova.Infrastructure.Interfaces
{
    public interface IRepository<T> where T: BaseEntity
    {
        Task AddAsync(T entity);
        Task DeleteAsync(long id);
        Task<T> GetByIdAsync(long id);
        IQueryable<T> GetAll();
        Task SaveAsync();
       // Task<PaginatedResult<TDto>>
    }
}
