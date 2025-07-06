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

        public StudentsController(ILogger<StudentsController> logger, IRegisterService registerService)
        {
            _logger = logger;
            _registerService = registerService;
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
            return await _registerService.Authenticate(request);
        }


        [HttpGet("me")]
        public async Task<List<Student>> GetMe()
        {
            return await _registerService.Get();
        }
    }
}
