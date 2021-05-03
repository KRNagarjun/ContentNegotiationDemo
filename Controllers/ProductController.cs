using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentNegotiationDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [FormatFilter]
    public class ProductController : ControllerBase
    {
        [HttpGet("{id}.{format?}")]
        public Product Get(int id)
        {
            return new Product();
        }
    }

    public class Product
    {
    }
}
