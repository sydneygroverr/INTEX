namespace INTEX_0105.Models
{
    public interface IProductRepository
    {
        public IQueryable<Product> Products { get; }

    }
}
