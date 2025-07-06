namespace Request
{
    // Necessary data that must be entered upon creating the account (in a json form using FormBody)
    public class SignUpRequest
    {
        public string StudentId { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public int YearLevel { get; set; }

        public string EmailAddress { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string ConfirmPassowrd { get; set; } = null!;

    }
}