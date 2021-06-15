using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.DataAccess.Abstract;
using Core.DataAccess.Concrete;
using Infrastructure.DataContext;

namespace Infrastructure.Implementations.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T:BaseEntity
    {
        private readonly StoreContext _context;

        public GenericRepository(StoreContext context)
        {
            _context = context;
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<T>> GetListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
