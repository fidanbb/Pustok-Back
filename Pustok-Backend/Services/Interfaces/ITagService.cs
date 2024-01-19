using Microsoft.AspNetCore.Mvc.Rendering;
using Pustok_Backend.Areas.Admin.ViewModels.Tag;

namespace Pustok_Backend.Services.Interfaces
{
    public interface ITagService
    {
        Task<List<TagVM>> GetAllAsync();
        Task<int> GetCountAsync();
        Task<List<TagVM>> GetPaginatedDatas(int page,int take);
        Task<TagVM> GetByIdWithoutTrackingAsync(int id);
        Task DeleteAsync(int id);
        Task CreateAsync(TagCreateVM tag);
        Task EditAsync(TagEditVM tag);
        Task<TagVM> GetByNameWithoutTrackingAsync(string name);
        List<SelectListItem> GetAllTagsAsync();

        List<SelectListItem> GetAllSelectedTagsAsync(List<int> selected);
    }
}
