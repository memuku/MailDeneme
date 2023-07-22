using MailDeneme.Model;

namespace MailDeneme.Services
{
    public interface IMailService
    {
        Task<bool> SendAsync(MailData mailData, CancellationToken ct);
    }

}
