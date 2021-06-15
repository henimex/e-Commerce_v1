using Core.DataAccess.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.DataAccess.Abstract
{
    public interface IGenericRepository<T> where T: BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> GetListAsync();
    }
}
