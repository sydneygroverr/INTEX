namespace INTEX_0105.Models
{
    public class EFProductRepository : IProductRepository
    {
        private ProductContext _context;
        public EFProductRepository(ProductContext temp)
        {
            _context = temp;
        }
        public IQueryable<Product> Products => _context.Products;
    }
}

