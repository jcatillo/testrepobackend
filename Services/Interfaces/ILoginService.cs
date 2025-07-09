using Request;
using Response;
namespace Interfaces
{
    public interface ILoginService
    {
        Task<AuthResponse> SignIn(SignInRequest signIn);
    }
}