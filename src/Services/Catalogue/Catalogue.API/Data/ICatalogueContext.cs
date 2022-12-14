using Catalogue.API.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogue.API.Data
{
    public interface ICatalogueContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
