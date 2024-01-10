using Pustok_Backend.Areas.Admin.ViewModels.Slider;

namespace Pustok_Backend.Services.Interfaces
{
    public interface ISliderService
    {
        Task<List<SliderVM>> GetAllAsync();
        Task<SliderVM> GetByIdWithoutTrackingAsync(int id);

        Task CreateAsync(SliderCreateVM slider);

        Task DeleteAsync(int? id);

        Task EditAsync(SliderEditVM slider);
    }
}