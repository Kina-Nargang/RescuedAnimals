using AnimalCatalogAPI.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalCatalogAPI.Data
{
    public static class CatalogSeed
    {
        public static void Seed(CatalogContext context)
        {
            // add migrateion
            context.Database.Migrate();

            if (!context.CatalogBreeds.Any())
            {
                // add rows
                context.CatalogBreeds.AddRange(GetconfiguredCatalogBreeds());
                // save
                context.SaveChanges();
            }

            if (!context.Catalogtypes.Any())
            {
                // add rows
                context.Catalogtypes.AddRange(GetconfiguredCatalogTypes());
                // save
                context.SaveChanges();
            }

            if (!context.CatalogItems.Any())
            {
                // add rows
                context.Catalogtypes.AddRange(GetconfiguredCatalogItems());
                // save
                context.SaveChanges();
            }
        }

        private static IEnumerable<CatalogItem> GetconfiguredCatalogItems()
        {
            return new List<CatalogItem>
            {
                new CatalogItem { Age = 4, Color = "White", Gender = "F", Name = "Lily",
                Price = 200, Size = "Large", SpayedOrNeutered = "Yes",
                Description = "This a cute snowball dog that is wating to be adopted." ,
                PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/1"
                },

            };
            
        }

        private static IEnumerable<CatalogType> GetconfiguredCatalogTypes()
        {
            return new List<CatalogType>
            {
                new CatalogType{Type = "Dogs"},
                new CatalogType{Type = "Cats"},
                new CatalogType{Type = "Others"}
            };
        }

        private static IEnumerable<CatalogBreed> GetconfiguredCatalogBreeds()
        {
            return new List<CatalogBreed>
            {
                new CatalogBreed { Breed = "Chihuahua"},
                new CatalogBreed { Breed = "Bull Terrier"},
                new CatalogBreed { Breed = "Pit Bull"},
                new CatalogBreed { Breed = "Labrador Retriever"},
                new CatalogBreed { Breed = "Golden Retriever"},
                new CatalogBreed { Breed = "Akita"},
                new CatalogBreed { Breed = "Shibainu"},
                new CatalogBreed { Breed = "Alaska Husky"},
                new CatalogBreed { Breed = "Siberian Husky"},
                new CatalogBreed { Breed = "German Shepherd"},
                new CatalogBreed { Breed = "Samoyed"},
                new CatalogBreed { Breed = "American Bobtail"},
                new CatalogBreed { Breed = "American Curl"},
                new CatalogBreed { Breed = "American Wirehair"},
                new CatalogBreed { Breed = "Balinese"},
                new CatalogBreed { Breed = "Bombay"},
                new CatalogBreed { Breed = "Devon Rex "},
                new CatalogBreed { Breed = "Himalayan"},
                new CatalogBreed { Breed = "Javanese"},
                new CatalogBreed { Breed = "Hummingbird "}

            };
        }
    }
}
