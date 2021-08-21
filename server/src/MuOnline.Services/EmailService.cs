using Microsoft.Extensions.Options;
using MuOnline.Domain.Interfaces.Services;
using MuOnline.Infrastruture.Application.Settings;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MuOnline.Services
{
    public class EmailService : IEmailService
    {
        private string Smtp { get; }
        private int Port { get; }
        private string UserName { get; }
        private string Password { get; }

        public EmailService(IOptions<AppSettings> appSettings)
        {
            Smtp = appSettings?.Value?.EmailConfiguration?.PrimaryDomain;
            Port = (int)appSettings?.Value?.EmailConfiguration?.PrimaryPort;
            UserName = appSettings?.Value?.EmailConfiguration?.UsernameEmail;
            Password = appSettings?.Value?.EmailConfiguration?.UsernamePassword;
        }

        public async Task SendAsync(MailAddress address, string subjectMatter, string messageBody)
        {
            var emailMessage = AssembleEmailMessage(subjectMatter, messageBody);
            emailMessage.To.Add(address);
            emailMessage.CC.Add(UserName);

            try
            {
                using var client = AssembleEmailCredentials();
                await client.SendMailAsync(emailMessage);
            }
            catch (SmtpException ex)
            {
                throw new SmtpException("Erro ao enviar e-mail", ex.InnerException);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao enviar e-mail", ex.InnerException);
            }
        }
        
        private MailMessage AssembleEmailMessage(string subjectMatter, string messageBody)
        {
            return new MailMessage()
            {
                From = new MailAddress(UserName, "Mu"),
                Priority = MailPriority.Normal,
                IsBodyHtml = true,
                Subject = subjectMatter,
                Body = messageBody
            };
        }

        private SmtpClient AssembleEmailCredentials()
        {
            return new SmtpClient(Smtp, Port)
            {
                EnableSsl = true,
                UseDefaultCredentials = true,
                Credentials = new NetworkCredential(UserName, Password)
            };
        }
    }
}