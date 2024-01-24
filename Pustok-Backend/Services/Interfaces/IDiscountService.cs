using Pustok_Backend.Areas.Admin.ViewModels.Category;
using Pustok_Backend.Areas.Admin.ViewModels.Discount;

namespace Pustok_Backend.Services.Interfaces
{
    public interface IDiscountService
    {
        Task<List<DiscountVM>> GetPaginatedDatasAsync(int page, int take);
        Task<DiscountVM> GetByIdWithoutTrackingAsync(int id);

        Task<int> GetCountAsync();

        Task DeleteAsync(int id);
        Task CreateAsync(DiscountCreateVM discount);
        Task EditAsync(DiscountEditVM discount);
        Task<DiscountVM> GetByNameWithoutTrackingAsync(string name);

        Task<List<DiscountVM>> GetAllAsync();
    }
}
