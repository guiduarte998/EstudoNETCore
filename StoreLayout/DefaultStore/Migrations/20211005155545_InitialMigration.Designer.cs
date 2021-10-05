﻿// <auto-generated />
using DefaultStore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DefaultStore.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20211005155545_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DefaultStore.Models.Product", b =>
                {
                    b.Property<int>("Barcode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Barcode");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Barcode = 123343453,
                            Description = "Grãos",
                            Name = "Arroz",
                            Price = 0.98m
                        },
                        new
                        {
                            Barcode = 123456710,
                            Description = "Grãos",
                            Name = "Feijão",
                            Price = 1.69m
                        },
                        new
                        {
                            Barcode = 987654321,
                            Description = "Proteina",
                            Name = "Carne",
                            Price = 4.79m
                        },
                        new
                        {
                            Barcode = 123456789,
                            Description = "Liquido",
                            Name = "Azeite",
                            Price = 2.00m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
