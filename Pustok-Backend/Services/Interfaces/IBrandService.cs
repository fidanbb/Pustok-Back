using Pustok_Backend.Areas.Admin.ViewModels.Brand;

namespace Pustok_Backend.Services.Interfaces
{
    public interface IBrandService
    {
        Task<ICollection<BrandVM>> GetAllAsync();
        Task<BrandVM> GetByIdAsync(int id);
        Task CreateAsync(BrandCreateVM brand);
        Task DeleteAsync(int? id);
        Task EditAsync(BrandEditVM brand);
    }
}
