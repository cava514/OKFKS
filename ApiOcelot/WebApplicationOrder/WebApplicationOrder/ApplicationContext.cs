using Microsoft.EntityFrameworkCore;
using WebApplicationOrder;

namespace WebApplicationRedis
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public ApplicationContext() { }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
