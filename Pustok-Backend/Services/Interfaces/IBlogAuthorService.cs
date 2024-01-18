using Pustok_Backend.Areas.Admin.ViewModels.BlogAuthor;
using Pustok_Backend.Areas.Admin.ViewModels.Tag;

namespace Pustok_Backend.Services.Interfaces
{
    public interface IBlogAuthorService
    {
       Task<List<BlogAuthorVM>> GetPaginatedDatasAsync(int page,int take);
       Task<BlogAuthorVM> GetByIdWithoutTrackingAsync(int id);

        Task<int> GetCountAsync();

        Task DeleteAsync(int id);
        Task CreateAsync(BlogAuthorCreateVM blogAuthor);
        Task EditAsync(BlogAuthorEditVM blogAuthor);
        Task<BlogAuthorVM> GetByNameWithoutTrackingAsync(string name);
        Task<List<BlogAuthorVM>> GetAllAsync();
    }
}
