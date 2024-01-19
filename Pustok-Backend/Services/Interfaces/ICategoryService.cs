using Pustok_Backend.Areas.Admin.ViewModels.Category;

namespace Pustok_Backend.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<List<CategoryVM>> GetAllAsync();
    }
}
