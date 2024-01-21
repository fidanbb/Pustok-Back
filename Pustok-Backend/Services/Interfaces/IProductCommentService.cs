using Pustok_Backend.Areas.Admin.ViewModels.BlogComment;
using Pustok_Backend.Areas.Admin.ViewModels.ProductComment;
using Pustok_Backend.Models;

namespace Pustok_Backend.Services.Interfaces
{
    public interface IProductCommentService
    {
        Task CreateAsync(ProductComment comment);
        Task<List<ProductCommentVM>> GetAllAsync(int page, int take);
        Task<ProductCommentVM> GetByIdAsync(int id);
        Task DeleteAsync(int? id);
        Task<int> GetCountAsync();
    }
}
