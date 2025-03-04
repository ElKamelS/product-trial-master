using Project.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Infrastructure
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Products>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<Products> GetProductByIdAsync(int id)
        {
            return await _productRepository.GetAsync(id);
        }

        public async Task AddProductAsync(Products product)
        {
            await _productRepository.AddAsync(product);
        }

        public async Task UpdateProductAsync(Products product)
        {
            await _productRepository.UpdateAsync(product);
        }

        public async Task DeleteProductAsync(int id)
        {
            await _productRepository.DeleteAsync(id);
        }
    }
}
