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
    public class GetListUserController : Controller
    {
        [HttpGet]
        public IActionResult Index ( )
        {
            List<User> userS = new List<User>();
            userS.Add(new User { idUser = 1, nameUser = "NCQ" });
            userS.Add(new User { idUser = 2, nameUser = "NHL" });
            return Ok(userS);
            //return Ok(new { status = "Success", data = userS });
        }
    }
}
