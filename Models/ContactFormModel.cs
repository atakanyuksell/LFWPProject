using System.ComponentModel.DataAnnotations;

namespace LawFirmWebPage.Models
{
    public class ContactFormModel
    {
        public int Id { get; set; } // Birincil anahtar

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Message { get; set; }

        public DateTime SentDate { get; set; } = DateTime.Now; // Mesaj gönderildiği zaman
    }
}


