using Pustok_Backend.Areas.Admin.ViewModels.Subscribe;

namespace Pustok_Backend.Services.Interfaces
{
    public interface ISubscribeService
    {
        Task<List<SubscribeVM>> GetAllAsync();
        Task DeleteAsync(int? id);
        Task CreateAsync(SubscribeCreateVM subscribe);

        Task<SubscribeVM> GetByEmailAsync(string email);
    }
}
