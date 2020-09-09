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


    }
}
