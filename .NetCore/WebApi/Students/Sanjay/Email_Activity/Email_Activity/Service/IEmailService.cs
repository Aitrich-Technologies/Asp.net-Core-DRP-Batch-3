namespace Email_Activity.Service
{
    public interface IEmailService
    {
        Task SendEmailAsync(string toEmail, string subject, string body);

    }
}
