using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using backend.Context;
using backend.Models;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using Request;
using Response;

namespace Services
{
    public class RegisterService : IRegisterService
    {
        private readonly CspsContext _context;
        private readonly JwtAuthService _jwtAuthService;

        public RegisterService(CspsContext context, JwtAuthService jwtAuthService)
        {
            _context = context;
            _jwtAuthService = jwtAuthService;
        }

        
        public async Task<List<Student>> Get()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<AuthResponse> Authenticate(SignInRequest loginRequest)
        {
            if (string.IsNullOrWhiteSpace(loginRequest.StudentId) || string.IsNullOrEmpty(loginRequest.Password))
                return null;

            var student = await _context.Students.FirstOrDefaultAsync(s => s.StudentId == loginRequest.StudentId);

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

        // For Signup Method, I manually increment the pk ID as of the moment because it'll not auto increment (most likely to be changed)
        public async Task<AuthResponse> RegisterAsync(SignUpRequest authResponse)
        {
            string password = authResponse.Password;
            string confirmPassword = authResponse.ConfirmPassowrd;
            bool validation = await EmailAndUserValidation(authResponse.EmailAddress, authResponse.StudentId);

            int latestId = await _context.Students
            .OrderByDescending(s => s.Id)
            .Select(s => s.Id)
            .FirstOrDefaultAsync();

            if (!validation) return null;
            if (password != confirmPassword)
                return null;

            var newStudent = new Student
            {
                StudentId = authResponse.StudentId,
                FirstName = authResponse.FirstName,
                LastName = authResponse.LastName,
                YearLevel = authResponse.YearLevel,
                EmailAddress = authResponse.EmailAddress,
                Password = BCrypt.Net.BCrypt.HashPassword(authResponse.Password),
                DateStamp = DateTime.Now,
                Id = latestId + 1
            };

            var token = _jwtAuthService.GenerateToken(newStudent);

            await _context.Students.AddAsync(newStudent);
            await _context.SaveChangesAsync();

            return new AuthResponse
            {
                Token = token,
                Email = authResponse.EmailAddress,
                LastName = authResponse.LastName,
                FirstName = authResponse.FirstName,
            };

        }

        // Helper Methods (To check if the studentId and email already Existed)
        private async Task<bool> EmailAndUserValidation(string email, string studentId)
        {
            bool emailExists = await _context.Students.AnyAsync(student => student.EmailAddress.ToLower()
                                                         == email.ToLower());
            bool studentIdExists = await _context.Students.AnyAsync(student => student.StudentId
                                                             == studentId);

            return !emailExists && !studentIdExists;

        }
    }
}