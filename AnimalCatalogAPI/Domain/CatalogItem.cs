﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalCatalogAPI.Domain
{
    public class CatalogItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string SpayedOrNeutered { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        public int CatalogTypeId { get; set; }
        public int CatalogBreedId { get; set; }
        // build relationship here
        public virtual CatalogType CatalogType { get; set; }
        public virtual CatalogBreed CatalogBreed { get; set; }
    }
}
