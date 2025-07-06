using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using backend.Context;
using backend.Models;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Models;
using Request;
using Response;

namespace Services
{
    public class JwtAuthService
    {
        private readonly JwtSettings _settings;

        // Injects the value of the "JwtSettings" in appsettings.json 
        public JwtAuthService(IOptions<JwtSettings> options)
        {
            _settings = options.Value;
        }

        /*
            Generates a Token

            * @param student, Student object that holds the token
            
         */
        public string GenerateToken(Student student)
        {
            // Mapped from studentid, and was being used in signinrequest
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, student.StudentId)
            };

            // JWT config
            var keyBytes = Encoding.UTF8.GetBytes(_settings.Key);
            var securityKey = new SymmetricSecurityKey(keyBytes);
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512);
            
            // JWT infos, and the token expires every 1 hour
            var token = new JwtSecurityToken(
                issuer: _settings.Issuer,
                audience: _settings.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(60),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
            

    }
}