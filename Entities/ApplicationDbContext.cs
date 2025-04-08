using LawFirmWebPage.Entities;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace LawFirmWebPage.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

        public DbSet<ContactMessage> ContactMessages { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Entity'lerin tablolara atanması
            modelBuilder.Entity<ContactMessage>().ToTable("ContactMessages");

            // JSON verilerinin okunması ve deserialization yapılması
            string contactMessagesJson = File.ReadAllText("mock.json");

            List<ContactMessage> contactMessages = JsonSerializer.Deserialize<List<ContactMessage>>(contactMessagesJson);

            // Veritabanına seed işlemi
            foreach (ContactMessage contactMessage in contactMessages)
            {
                modelBuilder.Entity<ContactMessage>().HasData(contactMessage);
            }
        }
    }

}
