using Catalog.API.Data.Interfaces;
using Catalog.API.Entities;
using Catalog.API.Settings;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalodContext : ICatalogContext
    {
        public CatalodContext(ICatalogDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            Products = database.GetCollection<Product>(settings.CollectionName);
        }
        public IMongoCollection<Product> Products { get; }
        //chandan roy 1986
    }
}
