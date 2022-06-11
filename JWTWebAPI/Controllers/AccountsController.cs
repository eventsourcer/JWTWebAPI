using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JWTWebAPI.Services;
using System.Threading.Tasks;
using JWTWebAPI.Models;
using System.Linq;

namespace JWTWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly UserContext _context;

        public AccountsController(ITokenService tokenService, UserContext userContext)
        {
            _tokenService = tokenService;
            _context = userContext;
        }

        [HttpPost("login")]
        public ActionResult Login(string username, string password)
        {
            var exists=_context.Users.Where(u=>u.Username == username && u.Password==password).Any();
            if(!exists)
                return Unauthorized();
            return new JsonResult(new { Username = username, Token = _tokenService.CreateToken(username) });
        }
    }
}
