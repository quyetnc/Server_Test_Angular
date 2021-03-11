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
    public class CheckApiGetController : Controller
    {
        [HttpGet]
        public IActionResult Index ()
        {
            return Ok(new { title = "This is title", value = 1999 });
        }
    }
}
