using Pustok_Backend.Areas.Admin.ViewModels.Service;

namespace Pustok_Backend.Services.Interfaces
{
    public interface ISiteServicesService
    {
        Task<ICollection<ServiceVM>> GetAllAsync();
        Task<ServiceVM> GetByIdWithoutTracking(int id);

        Task EditAsync(ServiceEditVM service);
    }
}
