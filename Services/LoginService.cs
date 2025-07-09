using backend.Context;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using Request;
using Response;

namespace Services
{
    public class LoginService : ILoginService
    {
        private readonly JwtAuthService _jwtAuthService;
        private readonly CspsContext _cspsContext;

        public LoginService(JwtAuthService jwtAuthService, CspsContext cspsContext)
        {
            _jwtAuthService = jwtAuthService;
            _cspsContext = cspsContext;
        }
        
        public async Task<AuthResponse> SignIn(SignInRequest loginRequest)
        {
            if (string.IsNullOrWhiteSpace(loginRequest.StudentId) || string.IsNullOrEmpty(loginRequest.Password))
                return null;

            var student = await _cspsContext.Students.FirstOrDefaultAsync(s => s.StudentId == loginRequest.StudentId);

            if (student == null)
                return null;

            // Verify password
            bool passwordValid = BCrypt.Net.BCrypt.Verify(loginRequest.Password, student.Password);
            if (!passwordValid)
                return null;

            // Generate JWT
            var token = _jwtAuthService.GenerateToken(student);

            return new AuthResponse
            {
                StudentId = student.StudentId,
                Token = token,
                Email = student.EmailAddress,
                FirstName = student.FirstName,
                LastName = student.LastName
            };
        }

    }
}