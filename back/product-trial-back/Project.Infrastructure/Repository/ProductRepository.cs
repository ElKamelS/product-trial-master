using Microsoft.EntityFrameworkCore;
using Project.DTO;
using Project.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Infrastructure
{
    public class ProductRepository : Repository<Products>, IProductRepository
    {
        private readonly ProductsDbContext _context;

        public ProductRepository(ProductsDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Products>> GetProductsByCategoryAsync(string category)
        {
            return await _context.Products
                                  .Where(p => p.category == category)
                                  .ToListAsync();
        }
    }
}
