﻿// <auto-generated />
using System;
using LawFirmWebPage.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LawFirmWebPage.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.36");

            modelBuilder.Entity("LawFirmWebPage.Entities.ContactMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("SentDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ContactMessages", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "deneme.yilmaz@example.com",
                            Message = "deneme",
                            Name = "Atakan",
                            SentDate = new DateTime(2025, 4, 8, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Surname = "Yüksel"
                        },
                        new
                        {
                            Id = 2,
                            Email = "mehmet.kaya@example.com",
                            Message = "Web sitenizle ilgili birkaç sorum var.",
                            Name = "Mehmet",
                            SentDate = new DateTime(2025, 4, 8, 10, 15, 0, 0, DateTimeKind.Unspecified),
                            Surname = "Kaya"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
