using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("AllowOrigin")]
    public class CheckApiPostController : Controller
    {
        [HttpPost]
        public IActionResult Index ( [FromBody] ModelPost _data )
        {
            return Ok(_data);
        }
    }
}
