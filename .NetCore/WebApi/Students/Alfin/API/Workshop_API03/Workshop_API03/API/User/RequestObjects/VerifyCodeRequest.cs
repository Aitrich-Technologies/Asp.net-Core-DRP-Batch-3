namespace Workshop_API03.API.User.RequestObjects
{
    public class VerifyCodeRequest
    {
        public string Email { get; set; }
        public string Code { get; set; }
        public string VerificationToken { get; set; }
    }
}
