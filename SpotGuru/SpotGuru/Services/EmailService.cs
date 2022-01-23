using Microsoft.Extensions.Options;
using SpotGuru.Helpers;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SpotGuru.Services
{
    public class EmailService : IEmailService
    {
        private readonly EmailSettings _mailSettings;
        public EmailService(IOptions<EmailSettings> emailSettings)
        {
            _mailSettings = emailSettings.Value;
        }


        public async Task SendEmail(string email, string subject, string message)
        {
            try
            {
                var MailMessage = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                MailMessage.From = new MailAddress(_mailSettings.Mail, _mailSettings.DisplayName);
                MailMessage.To.Add(new MailAddress(email));
                MailMessage.Subject = subject;

                MailMessage.Body = message;
                smtp.Port = _mailSettings.Port;
                smtp.Host = _mailSettings.Host;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(_mailSettings.Mail, _mailSettings.Password);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                await smtp.SendMailAsync(MailMessage);
            }
            catch (Exception e) { }
        }
    }
}
