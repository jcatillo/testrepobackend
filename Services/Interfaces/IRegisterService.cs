using System.Security.Claims;
using backend.Models;
using Request;
using Response;


namespace Interfaces
{

    // Interface for the registration service.
    // Defines the contract for registration logic, exposing only the available operations without revealing implementation details.
    public interface IRegisterService
    {
        Task<AuthResponse> RegisterAsync(SignUpRequest request);

        Task<List<Student>> Get();


    }
}