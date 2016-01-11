using ShoppingBusiness;
using System.Data.Entity;

namespace ShoppingData
{
    public class FruitShoppingDbContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }
}
