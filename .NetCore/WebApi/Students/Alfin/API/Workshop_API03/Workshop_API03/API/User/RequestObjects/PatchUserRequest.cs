namespace Workshop_API03.API.User.RequestObjects
{
    public class PatchUserRequest
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? TelephoneNo { get; set; }
    }
}
