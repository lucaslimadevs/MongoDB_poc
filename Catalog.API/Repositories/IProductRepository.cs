﻿using Catalog.API.Entities;

namespace Catalog.API.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(string id);
        Task<IEnumerable<Product>> GetByNameAsync(string name);
        Task<IEnumerable<Product>> GetByCategoryAsync(string category);
        Task CreateAsync(Product obj);
        Task<bool> UpdateAsync(Product obj);
        Task<bool> DeleteAsync(string id);
    }
}
