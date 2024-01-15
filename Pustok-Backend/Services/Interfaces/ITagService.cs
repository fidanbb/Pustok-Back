using Pustok_Backend.Areas.Admin.ViewModels.Tag;

namespace Pustok_Backend.Services.Interfaces
{
    public interface ITagService
    {
        Task<List<TagVM>> GetAllAsync();
    }
}
