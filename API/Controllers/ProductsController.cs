using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        //private readonly StoreContext _context;
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        /// <summary>
        /// Get All Product List Test
        /// </summary>
        /// <returns></returns>
        [HttpGet("ga-products")]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var data = await _productRepository.GetProductsAsync();
            return Ok(data);
        }

        [HttpGet("gs-product")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return Ok(await _productRepository.GetProductByIdAsync(id));
        }

        [HttpGet("ga-product-types")]
        public async Task<ActionResult<List<Product>>> GetProductTypes()
        {
            var data = await _productRepository.GetProductTypesAsync();
            return Ok(data);
        }

        [HttpGet("ga-product-brands")]
        public async Task<ActionResult<List<Product>>> GetProductBrands()
        {
            var data = await _productRepository.GetProductBrandsAsync();
            return Ok(data);
        }
    }
}
