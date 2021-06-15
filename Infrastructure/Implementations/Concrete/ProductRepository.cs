﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Concrete.EntityFramework;
using Infrastructure.DataContext;
using Infrastructure.Implementations.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Implementations.Concrete
{
    public class ProductRepository : IProductRepository
    {

        private readonly StoreContext _context;
        
        public ProductRepository(StoreContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await _context.Products
                .Include(p=> p.ProductBrand)
                .Include(p=>p.ProductType)
                .ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _context.Products
                .Include(p => p.ProductBrand)
                .Include(p => p.ProductType)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IReadOnlyList<ProductType>> GetProductTypesAsync()
        {
            return await _context.ProductTypes.ToListAsync();
        }

        public async Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync()
        {
            return await _context.ProductBrands.ToListAsync();
        }
    }
}
