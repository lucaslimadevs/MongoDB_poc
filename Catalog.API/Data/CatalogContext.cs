using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration configuration) 
        {
            var cliente = new MongoClient(configuration.GetValue<string>
                ("DatabaseSettings:ConnectionString"));

            var dataBase = cliente.GetDatabase(configuration.GetValue<string>
                ("DatabaseSettings:DatabaseName"));

            Products = dataBase.GetCollection<Product>(configuration.GetValue<string>
                ("DatabaseSettings:CollectionName"));

            CatalogContextSeed.SeedDatabase(Products);
        }

        public IMongoCollection<Product> Products { get; }
    }
}
 