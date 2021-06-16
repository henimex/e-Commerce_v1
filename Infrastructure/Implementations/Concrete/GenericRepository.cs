using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.DataAccess.Abstract;
using Core.DataAccess.Concrete;
using Core.Specifications;
using Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Implementations.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T:BaseEntity
    {
        private readonly StoreContext _context;

        public GenericRepository(StoreContext context)
        {
            _context = context;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> GetListAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public Task<T> GetEntityWithSpec(ISpecifications<T> spec)
        {
            throw new NotImplementedException();
            //TODO: Implementations
        }

        public Task<IReadOnlyList<T>> ListAsync(ISpecifications<T> spec)
        {
            throw new NotImplementedException();
            //TODO: Implementations
        }
    }
}
