using Catalog.API.Entities;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedDatabase(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();

            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetMyProducts());
            }
        }

        public static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>() 
            { 
                new Product 
                { 
                    Id = "6420e8b8bf90f34596a909dc",
                    Name = "Iphone X",
                    Description = @"Mussum Ipsum, cacilds vidis litro abertis. Praesent malesuada urna nisi, quis volutpat erat hendrerit non. Nam vulputate dapibus.Interagi no mé, cursus quis, vehicula ac nisi.",
                    Image = "product-1.png",
                    Price = 1000.95m,
                    Category = "Smart Phone"
                },
                new Product
                {
                    Id = ObjectId.GenerateNewId().ToString(),
                    Name = "Iphone XS",
                    Description = @"Mussum Ipsum, cacilds vidis litro abertis. Praesent malesuada urna nisi, quis volutpat erat hendrerit non. Nam vulputate dapibus.Interagi no mé, cursus quis, vehicula ac nisi.",
                    Image = "product-2.png",
                    Price = 920.95m,
                    Category = "Smart Phone"
                },
                new Product
                {
                    Id = ObjectId.GenerateNewId().ToString(),
                    Name = "Iphone 11",
                    Description = @"Mussum Ipsum, cacilds vidis litro abertis. Praesent malesuada urna nisi, quis volutpat erat hendrerit non. Nam vulputate dapibus.Interagi no mé, cursus quis, vehicula ac nisi.",
                    Image = "product-3.png",
                    Price = 2200.50m,
                    Category = "Smart Phone"
                },
                new Product
                {
                    Id = ObjectId.GenerateNewId().ToString(),
                    Name = "Iphone 13",
                    Description = @"Mussum Ipsum, cacilds vidis litro abertis. Praesent malesuada urna nisi, quis volutpat erat hendrerit non. Nam vulputate dapibus.Interagi no mé, cursus quis, vehicula ac nisi.",
                    Image = "product-4.png",
                    Price = 3500.52m,
                    Category = "Smart Phone"
                }
            };
        }
    }
}
