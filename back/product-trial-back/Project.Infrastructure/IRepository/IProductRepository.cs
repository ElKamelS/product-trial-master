using System.Collections.Generic;


namespace Project.Infrastructure
{
    using Project.DTO;
    using System.Threading.Tasks;

    public interface IProductRepository : IRepository<Products>
    {
        Task<IEnumerable<Products>> GetProductsByCategoryAsync(string category);
    }
}
