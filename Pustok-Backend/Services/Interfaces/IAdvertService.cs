using Pustok_Backend.Areas.Admin.ViewModels.Advert;

namespace Pustok_Backend.Services.Interfaces
{
    public interface IAdvertService
    {
        Task<List<AdvertVM>> GetAllAsync();
        Task<AdvertVM> GetByIdWithoutTracking(int id);

        Task EditAsync(AdvertEditVM advert);
    }
}
