﻿using AnimalCatalogAPI.Domain;
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

            if (!context.CatalogTypes.Any())
            {
                // add rows
                context.CatalogTypes.AddRange(GetconfiguredCatalogTypes());
                // save
                context.SaveChanges();
            }

            if (!context.CatalogItems.Any())
            {
                // add rows
                context.CatalogItems.AddRange(GetconfiguredCatalogItems());
                // save
                context.SaveChanges();
            }
        }

        private static IEnumerable<CatalogItem> GetconfiguredCatalogItems()
        {
            return new List<CatalogItem>
            {
                new CatalogItem { Age = 10, Color = "Mix", Gender = "F", Name = "Lily",
                Price = 200, Size = "Small", SpayedOrNeutered = "Yes",
                Description = "This a cute kitty that is wating to be adopted." ,
                PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/1",
                CatalogBreedId = 12, CatalogTypeId = 2
                },
                new CatalogItem { Age = 5, Color = "Mix", Gender = "F", Name = "Yoyo",
                Price = 200, Size = "Small", SpayedOrNeutered = "Yes",
                Description = "This a cute kitty that is wating to be adopted." ,
                PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/2",
                CatalogBreedId = 13, CatalogTypeId = 2
                },
                new CatalogItem { Age = 2, Color = "Grey", Gender = "M", Name = "Mio",
                Price = 200, Size = "Small", SpayedOrNeutered = "Yes",
                Description = "This a cute kitty that is wating to be adopted." ,
                PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/3",
                CatalogBreedId = 14, CatalogTypeId = 2
                },
                new CatalogItem { Age = 8, Color = "Orange", Gender = "M", Name = "Sayu",
                Price = 200, Size = "Small", SpayedOrNeutered = "Yes",
                Description = "This a cute kitty that is wating to be adopted." ,
                PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/4",
                CatalogBreedId = 15, CatalogTypeId = 2
                },
                new CatalogItem { Age = 9, Color = "Orange", Gender = "M", Name = "Kiki",
                Price = 200, Size = "Small", SpayedOrNeutered = "Yes",
                Description = "Like eating oranges." ,
                PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/5",
                CatalogBreedId = 16, CatalogTypeId = 2
                },
                new CatalogItem { Age = 5, Color = "White", Gender = "F", Name = "Lily",
                Price = 200, Size = "Large", SpayedOrNeutered = "Yes",
                Description = "This a cute snowball dog that is wating to be adopted." ,
                PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/6",
                CatalogBreedId = 13, CatalogTypeId = 2
                },
                new CatalogItem { Age = 2, Color = "Yellow", Gender = "M", Name = "Meatloaf",
                Price = 150, Size = "Small", SpayedOrNeutered = "Yes",
                Description = "Cute little guy is waiting to be adopted." ,
                PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/7",
                CatalogBreedId = 1, CatalogTypeId = 1
                },
                new CatalogItem { Age = 1, Color = "White & Black", Gender = "M", Name = "Hero",
                Price = 300, Size = "Small", SpayedOrNeutered = "Yes",
                Description = "Very hiper" ,
                PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/8",
                CatalogBreedId = 8, CatalogTypeId = 1
                },
                new CatalogItem { Age = 5, Color = "White", Gender = "M", Name = "Snowball",
                Price = 300, Size = "Medium", SpayedOrNeutered = "Yes",
                Description = "Cute little guy is waiting to be adopted." ,
                PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/9",
                CatalogBreedId = 4, CatalogTypeId = 1
                },
                new CatalogItem { Age = 3, Color = "Mix Color", Gender = "M", Name = "Rambo",
                Price = 300, Size = "Large", SpayedOrNeutered = "Yes",
                Description = "First blood" ,
                PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/10",
                CatalogBreedId = 10, CatalogTypeId = 1
                },
                new CatalogItem { Age = 1, Color = "Green", Gender = "M", Name = "Fye",
                Price = 400, Size = "Small", SpayedOrNeutered = "Yes",
                Description = "Flying very high." ,
                PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/11",
                CatalogBreedId = 20, CatalogTypeId = 3
                },
                new CatalogItem { Age = 1, Color = "White&Gray", Gender = "F", Name = "Tiny",
                Price = 100, Size = "Small", SpayedOrNeutered = "Yes",
                Description = "Likes eating peanuts." ,
                PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/12",
                CatalogBreedId = 21, CatalogTypeId = 3
                }
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
                new CatalogBreed { Breed = "Hummingbird"},
                new CatalogBreed { Breed = "Hamster"}

            };
        }
    }
}
