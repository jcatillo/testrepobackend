namespace Response
{
    // Entity that will be returned in a JSON form, after signing up an account along with the jwt token
    public class AuthResponse
    {

        public string Token { get; set; } = null!;

        public string StudentId { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string FirstName { get; set; } = null!;
        
        public int YearLevel { get; set; }
    }
}