using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess.Abstract;
using Entities.Concrete.EntityFramework;
using Infrastructure.DataContext;
using Infrastructure.Implementations.Abstract;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IGenericRepository<Product> _productRepository;
        private readonly IGenericRepository<ProductBrand> _brandRepository;
        private readonly IGenericRepository<ProductType> _typeRepository;

        public ProductsController(IGenericRepository<Product> productRepository, IGenericRepository<ProductBrand> brandRepository, IGenericRepository<ProductType> typeRepository)
        {
            _productRepository = productRepository;
            _brandRepository = brandRepository;
            _typeRepository = typeRepository;
        }

        /// <summary>
        /// Get All Product List Test
        /// </summary>
        /// <returns></returns>
        [HttpGet("ga-products")]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var data = await _productRepository.GetListAsync();
            return Ok(data);
        }

        [HttpGet("gs-product")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return Ok(await _productRepository.GetByIdAsync(id));
        }

        [HttpGet("ga-product-types")]
        public async Task<ActionResult<List<Product>>> GetProductTypes()
        {
            var data = await _typeRepository.GetListAsync();
            return Ok(data);
        }

        [HttpGet("ga-product-brands")]
        public async Task<ActionResult<List<Product>>> GetProductBrands()
        {
            var data = await _brandRepository.GetListAsync();
            return Ok(data);
        }
    }
}
