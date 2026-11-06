using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using WebApplicationProduct;

namespace WebApplicationRedis.Service
{
    public class ProductService
    {
        ApplicationContext db;
        public ProductService(ApplicationContext context)
        {
            db = context;
        }

        public async Task<List<Product?>> GetProducts()
        {
            return await db.Products.ToListAsync();
        }

        public async Task<Product?> GetProduct(int id)
        {
            return await db.Products.FirstOrDefaultAsync();
        }

        public async Task<Product?> CreateProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return product;
        }

        public async Task<Product?> IsAlive()
        {
            return null;
        }
    }
}