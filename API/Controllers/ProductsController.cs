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
        [HttpGet("get-all")]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var data = await _productRepository.GetProductsAsync();
            return Ok(data);
        }

        [HttpGet("get-single")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await _productRepository.GetProductByIdAsync(id);
        }
    }
}
