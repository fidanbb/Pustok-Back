using Pustok_Backend.Areas.Admin.ViewModels.Social;

namespace Pustok_Backend.Services.Interfaces
{
    public interface ISocialService
    {
        Task<List<SocialVM>> GetAllAsync();

        Task<SocialVM> GetByIdWithoutTrackingAsync(int id);

        Task EditAsync(SocialEditVM social);
    }
}
