using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;
        public ProductsController(StoreContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get All Product List Test
        /// </summary>
        /// <returns></returns>
        [HttpGet("get-all")]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var data = await _context.Products.ToListAsync();
            return data;
        }

        [HttpGet("get-single")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await _context.Products.FindAsync(id);
        }
    }
}
