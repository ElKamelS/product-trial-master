using Project.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Infrastructure
{
    public interface IProductService
    {
        Task<IEnumerable<Products>> GetAllProductsAsync();
        Task<Products> GetProductByIdAsync(int id);
        Task AddProductAsync(Products product);
        Task UpdateProductAsync(Products product);
        Task DeleteProductAsync(int id);
    }
}
