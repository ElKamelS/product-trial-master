using Microsoft.EntityFrameworkCore;

namespace Project.DTO
{
    public class ProductsDbContext : DbContext
    {
        private string connectionString;

        public ProductsDbContext()
        {
        }

        public ProductsDbContext(DbContextOptions<ProductsDbContext> options)
         : base(options)
        {
        }

        public DbSet<Products> Products { get; set; }
    }
}
