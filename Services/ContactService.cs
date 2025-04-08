using System.Net.Mail;
using System.Net;
using LawFirmWebPage.ServiceContracts;
using LawFirmWebPage.ServiceContracts.DTO;
using System.Threading.Tasks;
using LawFirmWebPage.Models;


namespace LawFirmWebPage.Services
{
    using System.Net;
    using System.Net.Mail;
    using System.Threading.Tasks;
    using LawFirmWebPage.Models;

    public class ContactService : IContactService
    {
        private readonly string _fromEmail = "atakanyuksell@hotmail.com";
        private readonly string _smtpServer = "smtp-mail.outlook.com";
        private readonly int _smtpPort = 587;
        private readonly string _smtpUsername = "atakanyuksell@hotmail.com";
        private readonly string _smtpPassword = "pmaslzwlcmnvusoo"; // Gerçek şifreyi buraya yaz

        public async Task<bool> SendEmailAsync(ContactFormModel request)
        {
            try
            {
                var mailMessage = new MailMessage
                {
                    From = new MailAddress(_fromEmail),
                    Subject = "Yeni İletişim Formu Mesajı",
                    Body = $@"
                    <p><strong>Adı:</strong> {request.Name}</p>
                    <p><strong>Soyadı:</strong> {request.Surname}</p>
                    <p><strong>E-posta:</strong> {request.Email}</p>
                    <p><strong>Mesaj:</strong><br>{request.Message}</p>
                ",
                    IsBodyHtml = true
                };

                mailMessage.To.Add("atakanyukselis@hotmail.com");

                using (var smtpClient = new SmtpClient(_smtpServer, _smtpPort))
                {
                    smtpClient.Credentials = new NetworkCredential(_smtpUsername, _smtpPassword);
                    smtpClient.EnableSsl = true;

                    await smtpClient.SendMailAsync(mailMessage);
                }

                return true;
            }
            catch (Exception ex)
            {
                // TODO: ex.Message loglanabilir
                return false;
            }
        }

    }

}
