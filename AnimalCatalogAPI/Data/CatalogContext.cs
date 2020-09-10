using AnimalCatalogAPI.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalCatalogAPI.Data
{
    // database context class, provides instruction to entity framework core 
    // when it is about to set the DB
    public class CatalogContext:DbContext
    {
        // dependency injection -> in constructor
        public CatalogContext(DbContextOptions options) : base(options)
        { }

        public DbSet<CatalogBreed> CatalogBreeds { get; set; }
        public DbSet<CatalogType> Catalogtypes { get; set; }
        public DbSet<CatalogItem> CatalogItems { get; set; }

        // override the baseclass's method to create your own tables
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatalogBreed>(e =>
            {
                // table name
                e.ToTable("CatalogBreeds");
                // set entities
                e.Property(b => b.Id)
                    .IsRequired()
                    .UseHiLo("catalog_breed_hilo");
                e.Property(b => b.Breed)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CatalogType>(e =>
            {
                e.ToTable("CatalogTypes");
                e.Property(t => t.Id)
                    .IsRequired()
                    .UseHiLo("catalog_type_hilo");
                e.Property(t => t.Type)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CatalogItem>(e =>
            {
                e.ToTable("CatalogItems");
                e.Property(i => i.Id)
                    .IsRequired()
                    .UseHiLo("catalog_item_hilo");
                e.Property(i => i.Name)
                    .IsRequired()
                    .HasMaxLength(100);
                e.Property(i => i.Age)
                    .IsRequired()
                    .HasMaxLength(100);
                e.Property(i => i.Color)
                    .IsRequired()
                    .HasMaxLength(50);
                e.Property(i => i.Description)
                    .HasMaxLength(200);
                e.Property(i => i.Gender)
                    .IsRequired()
                    .HasMaxLength(10);
                e.Property(i => i.PictureUrl)
                    .HasMaxLength(1000);
                e.Property(i => i.Price)
                    .IsRequired();
                e.Property(i => i.Size)
                    .IsRequired()
                    .HasMaxLength(10);
                e.Property(i => i.SpayedOrNeutered)
                    .IsRequired()
                    .HasMaxLength(5);
                e.HasOne(i => i.CatalogType)
                    .WithMany()
                    .HasForeignKey(i => i.CatalogTypeId);
                e.HasOne(i => i.CatalogBreed)
                    .WithMany()
                    .HasForeignKey(i => i.CatalogBreedId);
            });
        }
    }
}
