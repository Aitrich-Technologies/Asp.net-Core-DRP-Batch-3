namespace RazorWorkshop2.Dtos
{
    public class UserchangePasswordDto
    {
        public string UserName { get; set; } = null!;
        public string CurrentPassword { get; set; }= null!;
        public string NewPassword { get; set; } = null!;
    }
}
