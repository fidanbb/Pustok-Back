using Pustok_Backend.Areas.Admin.ViewModels.Blog;

namespace Pustok_Backend.Services.Interfaces
{
    public interface IBlogService
    {
        Task<List<BlogVM>> GetAllWithTakeInDescendingOrderAsync(int take);
        Task<int> GetCountAsync(int? tagId, string searchText);

        Task<List<BlogVM>> GetPaginatedDatasAsync(int page, int take, int? tagId, string searchText);
    }
}
