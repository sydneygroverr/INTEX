using Microsoft.EntityFrameworkCore;

namespace INTEX_0105.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }

    }
}

