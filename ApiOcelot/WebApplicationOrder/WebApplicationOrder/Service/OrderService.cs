using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using WebApplicationOrder;

namespace WebApplicationRedis.Service
{
    public class OrderService
    {
        ApplicationContext db;
        public OrderService(ApplicationContext context)
        {
            db = context;
        }

        public async Task<List<Order?>> GetOrders()
        {
            return await db.Orders.ToListAsync();
        }

        public async Task<Order?> GetOrder(int id)
        {
            return await db.Orders.FirstOrDefaultAsync();
        }

        public async Task<Order?> CreateOrder(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return order;
        }

        public async Task<Order?> IsAlive()
        {
            return null;
        }
    }
}