using Pustok_Backend.Areas.Admin.ViewModels.Author;

namespace Pustok_Backend.Services.Interfaces
{
    public interface IAuthorService
    {
        Task<List<AuthorVM>> GetPaginatedDatasAsync(int page, int take);
        Task<AuthorVM> GetByIdWithoutTrackingAsync(int id);

        Task<int> GetCountAsync();

        Task DeleteAsync(int id);
        Task CreateAsync(AuthorCreateVM author);
        Task EditAsync(AuthorEditVM author);
        Task<AuthorVM> GetByNameWithoutTrackingAsync(string name);
    }
}
