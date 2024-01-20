using Pustok_Backend.Areas.Admin.ViewModels.Product;

namespace Pustok_Backend.Services.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductVM>> GetFeaturedProductsWithTakeAsync(int take);
        Task<List<ProductVM>> GetNewArrivedProductsWithTakeAsync(int take);
        Task<List<ProductVM>> GetMostViewedProductsWithTakeAsync(int take);
        Task<List<ProductVM>> GetDealOfTheDayProductsWithTakeAsync(int take);

        Task<int> GetTotalProductCountAsync();
        Task<List<ProductVM>> GetBestSellerProductsAsync();
        Task<List<ProductVM>> GetProductsByCategoryWithTakeAsync(int take,string categoryName);

        Task<List<ProductVM>> GetPaginatedDatasAsync(int page, int take, int? categoryId, string sortValue, string searchText, int? minValue, int? maxValue);

        Task<int> GetCountAsync(int? categoryId, string sortValue, string searchText, int? minValue, int? maxValue);



    }
}
