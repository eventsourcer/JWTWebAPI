using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JWTWebAPI.Models;

namespace JWTWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        
        [AllowAnonymous]
        [HttpGet("first")]
        public ActionResult First()
        {
            return Ok();    
        }
        [HttpGet("second")]
        [Authorize]
        public ActionResult Second()
        {
            return Ok();
        }
    }
}
