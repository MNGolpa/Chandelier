namespace ShopManagement.Domain.ProductCategoryAgg
{
    public interface IProductCategoryRepository
    {
        void Add(ProductCategory entity);
        ProductCategory GetDetails(long id);
        List<ProductCategory> GetAll();
    }
}
