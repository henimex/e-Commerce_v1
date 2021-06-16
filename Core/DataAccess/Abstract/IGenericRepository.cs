using Core.DataAccess.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Specifications;

namespace Core.DataAccess.Abstract
{
    public interface IGenericRepository<T> where T: BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> GetListAsync();

        Task<T> GetEntityWithSpec(ISpecifications<T> spec);
        Task<IReadOnlyList<T>> ListAsync(ISpecifications<T> spec);
    }
}
