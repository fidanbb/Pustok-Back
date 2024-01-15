using Pustok_Backend.Areas.Admin.ViewModels.Testimonial;

namespace Pustok_Backend.Services.Interfaces
{
    public interface ITestimonialService
    {
        Task<List<TestimonialVM>> GetWithIncludesAndTakeAsync(int take);
        Task<List<TestimonialVM>> GetAllAsync();

        Task<TestimonialVM> GetByIdAsync(int id);

        Task DeleteAsync(int? id);
    }
}
