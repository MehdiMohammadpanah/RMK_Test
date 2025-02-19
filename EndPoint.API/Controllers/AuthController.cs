using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        [Authorize]
        [HttpGet("Public")]
        public async Task<IActionResult> PublicAction() => Ok("Public Action OK");

        [Authorize(Roles = "role_admin")]
        [HttpGet("Private")]

        public async Task<IActionResult> PrivateAction() => Ok("Private Action OK");

       
    }
}
