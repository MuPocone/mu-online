using System.Net.Mail;
using System.Threading.Tasks;

namespace MuOnline.Domain.Interfaces.Services
{
    public interface IEmailService
    {
        Task SendAsync(MailAddress address, string subjectMatter, string messageBody);
    }
}