using DefaultStore.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DefaultStore.Repositories
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
        : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var schemaName = Schemas.Store;


            modelBuilder.Entity<Product>()
            .HasKey(b => b.Barcode);

            modelBuilder.Entity<Product>()
            .Property(b => b.Barcode)
            .IsRequired();

            modelBuilder.Entity<Product>()
            .Property(b => b.Name)
            .IsRequired();

            modelBuilder.Entity<Product>()
            .Property(b => b.Description)
            .IsRequired();

            modelBuilder.Entity<Product>()
            .Property(b => b.Price)
            .IsRequired();

            modelBuilder.Entity<Product>()
                .ToTable("Products", schemaName);

            modelBuilder.Entity<Product>().HasData(
                new Product { Barcode = 123343453, Name = "Arroz", Description = "Grãos", Price = 0.98M },
                new Product { Barcode = 123456710, Name = "Feijão", Description = "Grãos", Price = 1.69M },
                new Product { Barcode = 987654321, Name = "Carne", Description = "Proteina", Price = 4.79M },
                new Product { Barcode = 123456789, Name = "Azeite", Description = "Liquido", Price = 2.00M });
        }
        //entities
        public DbSet<Product> Products { get; set; }
    }

    public class Schemas
    {
        public const String Store = "Store";

    }
}
