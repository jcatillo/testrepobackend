using backend.Context;
using backend.Models;
using Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Request;
using Response;
using Services;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class StudentsController : ControllerBase
    {
        private readonly ILogger<StudentsController> _logger;
        private readonly IRegisterService _registerService;
        private readonly ILoginService _loginService;

        public StudentsController(ILogger<StudentsController> logger, IRegisterService registerService, ILoginService loginService)
        {
            _logger = logger;
            _registerService = registerService;
            _loginService = loginService;
        }

        [HttpPost("/auth/register")]
        [AllowAnonymous]
        public async Task<ActionResult<AuthResponse>> Register([FromBody] SignUpRequest students)
        {

            return await _registerService.RegisterAsync(students);

        }

        [HttpPost("/auth/login")]
        [AllowAnonymous]
        public async Task<ActionResult<AuthResponse>> Login([FromBody] SignInRequest request)
        {
            return await _loginService.SignIn(request);
        }


        [HttpGet("me")]
        public async Task<List<Student>> GetMe()
        {
            return await _registerService.Get();
        }
    }
}
