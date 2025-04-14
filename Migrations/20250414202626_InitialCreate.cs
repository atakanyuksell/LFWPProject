using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LawFirmWebPage.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Surname = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Message = table.Column<string>(type: "TEXT", nullable: false),
                    SentDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactMessages", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ContactMessages",
                columns: new[] { "Id", "Email", "Message", "Name", "SentDate", "Surname" },
                values: new object[] { 1, "deneme.yilmaz@example.com", "deneme", "Atakan", new DateTime(2025, 4, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), "Yüksel" });

            migrationBuilder.InsertData(
                table: "ContactMessages",
                columns: new[] { "Id", "Email", "Message", "Name", "SentDate", "Surname" },
                values: new object[] { 2, "mehmet.kaya@example.com", "Web sitenizle ilgili birkaç sorum var.", "Mehmet", new DateTime(2025, 4, 8, 10, 15, 0, 0, DateTimeKind.Unspecified), "Kaya" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactMessages");
        }
    }
}
