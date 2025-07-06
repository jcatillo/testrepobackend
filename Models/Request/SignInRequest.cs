namespace Request
{

    /*
        A body request for login
     */
    public class SignInRequest
    {
        public string StudentId { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}