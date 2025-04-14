namespace LawFirmWebPage.Entities
{
    public class ContactMessage
    {
        public int Id { get; set; } // Birincil anahtar
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime SentDate { get; set; } = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow,
    TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time")); // Mesaj gönderildiği zaman
    }
}
