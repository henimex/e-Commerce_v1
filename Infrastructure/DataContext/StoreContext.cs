﻿using Entities.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataContext
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; } 
        public DbSet<ProductBrand> ProductBrands { get; set; } 
        public DbSet<ProductType> ProductTypes { get; set; } 
    }
}
