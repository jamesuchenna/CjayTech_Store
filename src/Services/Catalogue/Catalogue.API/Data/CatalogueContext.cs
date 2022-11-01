using Catalogue.API.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogue.API.Data
{
    public class CatalogueContext : ICatalogueContext
    {
        public CatalogueContext(IConfiguration config)
        {
            var client = new MongoClient(config.GetValue<string>("DatabaseSettings:ConnectionString"));
            var database = client.GetDatabase(config.GetValue<string>("DatabaseSettings:DatabaseName"));
            Products = database.GetCollection<Product>(config.GetValue<string>("DatabaseSettings:CollectionName"));
            CatalogueContextSeed.SeedData(Products);
        }
        public IMongoCollection<Product> Products { get; }
    }
}
