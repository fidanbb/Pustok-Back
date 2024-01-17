﻿using Pustok_Backend.Areas.Admin.ViewModels.Blog;
using Pustok_Backend.Areas.Admin.ViewModels.BlogComment;
using Pustok_Backend.Models;

namespace Pustok_Backend.Services.Interfaces
{
    public interface IBlogService
    {
        Task<List<BlogVM>> GetAllWithTakeInDescendingOrderAsync(int take);
        Task<int> GetCountAsync(int? tagId, int? month, string searchText);
      
        Task<List<BlogVM>> GetPaginatedDatasAsync(int page, int take, int? tagId, int? month, string searchText);

        Task<BlogDetailVM> GetByIdWithoutTrackingAsync(int id);

        Task<List<BlogVM>> GetRelatedDatasAsync(BlogDetailVM currentBlog, int take);

        Task<List<(int Month, int Count)>> GetDatesOfDatasAsync();

        Task CreateCommentAsync(BlogComment comment);
    }
}
