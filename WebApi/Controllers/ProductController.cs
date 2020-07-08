using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllProduct()
        {
            return Ok("Sản phẩm 1, Sản phẩm 2");
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(string id)
        {
            return Ok("Sản phẩm thứ "+id );
        }

    }
}
