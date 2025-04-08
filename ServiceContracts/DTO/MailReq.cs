using System.ComponentModel.DataAnnotations;

namespace LawFirmWebPage.ServiceContracts.DTO
{
    public class MailReq 
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Message {  get; set; }
    }
}
