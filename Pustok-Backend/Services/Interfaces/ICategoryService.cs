using Pustok_Backend.Areas.Admin.ViewModels.Category;

namespace Pustok_Backend.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<List<CategoryVM>> GetAllAsync();

        Task<List<CategoryVM>> GetPaginatedDatasAsync(int page, int take);
        Task<CategoryVM> GetByIdWithoutTrackingAsync(int id);

        Task<int> GetCountAsync();

        Task DeleteAsync(int id);
        Task CreateAsync(CategoryCreateVM category);
        Task EditAsync(CategoryEditVM category);
        Task<CategoryVM> GetByNameWithoutTrackingAsync(string name);
    }
}
