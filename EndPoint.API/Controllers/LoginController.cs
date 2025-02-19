using Application.DTOs;
using Application.Interfaces.Contexts;
using Application.Services.LoginService;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        private readonly IDataBaseContext _context;
        private readonly IConfiguration _configuration;
        private readonly IAuthenticationService _authService;

       
        public LoginController(IDataBaseContext context,IConfiguration configuration, IAuthenticationService authService)
        {
            _context = context;
            _configuration = configuration;
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto dto)
        {
            try
            {
                var token = await _authService.LoginAsync(dto.Username, dto.Password);
                return Ok(new { Token = token });
            }
            catch (Exception ex)
            { 
                return BadRequest(ex.Message);
            }
        }

    }
}
