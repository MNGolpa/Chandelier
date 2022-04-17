namespace ShopManagement.Application.Contracts.ProductCategory
{
    public interface IProductCategoryApplication
    {
        void Add(AddProductCategory command);
        void Edit(EditProductCategory command);
        Domain.ProductCategoryAgg.ProductCategory GetDetails(long id);
        List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel);
    }
}
