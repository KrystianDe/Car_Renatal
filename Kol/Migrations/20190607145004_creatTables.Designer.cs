﻿// <auto-generated />
using System;
using Kol.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kol.Migrations
{
    [DbContext(typeof(RentDbContext))]
    [Migration("20190607145004_creatTables")]
    partial class creatTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Kol.Models.Car", b =>
                {
                    b.Property<int>("IdCar")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(150)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("RegisterNumber")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("IdCar");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Kol.Models.Rent", b =>
                {
                    b.Property<int>("IdRent")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Client")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DateFrom");

                    b.Property<DateTime>("DateTo");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("IdCar");

                    b.HasKey("IdRent");

                    b.HasIndex("IdCar");

                    b.ToTable("Rents");
                });

            modelBuilder.Entity("Kol.Models.Rent", b =>
                {
                    b.HasOne("Kol.Models.Car", "Car")
                        .WithMany("Rents")
                        .HasForeignKey("IdCar")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}