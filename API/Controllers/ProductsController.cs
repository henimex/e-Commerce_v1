using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet("get-all")]
        public string GetProducts()
        {
            return "List of Products";
        }

        [HttpGet("get-single")]
        public string GetProduct(string pName)
        {
            return "Single Product Information " + pName;
        }
    }
}
