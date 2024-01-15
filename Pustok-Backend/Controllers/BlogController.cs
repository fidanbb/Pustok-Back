using Microsoft.AspNetCore.Mvc;
using Pustok_Backend.Areas.Admin.ViewModels.Blog;
using Pustok_Backend.Areas.Admin.ViewModels.Tag;
using Pustok_Backend.Helpers;
using Pustok_Backend.Models;
using Pustok_Backend.Services.Interfaces;
using Pustok_Backend.ViewModels;

namespace Pustok_Backend.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ITagService _tagService;
        public BlogController(IBlogService blogService,
                              ITagService tagService)
        {
            _blogService = blogService;
            _tagService = tagService;

        }
        public async Task<IActionResult> Index(int page = 1, int take = 6,int? tagId=null,string searchText=null)
        {
            List<BlogVM> dbPaginatedDatas = await _blogService.GetPaginatedDatasAsync(page, take,tagId,searchText);

            int pageCount = await GetPageCountAsync(take,tagId,searchText);

            Paginate<BlogVM> paginatedDatas = new(dbPaginatedDatas, page, pageCount);
            List<TagVM> tags=await _tagService.GetAllAsync();

            BlogPageVM model = new()
            {
                PaginatedDatas = paginatedDatas,
                Tags = tags
            };

            return View(model);
        }

        private async Task<int> GetPageCountAsync(int take, int? tagId, string searchText)
        {
            int blogCount = await _blogService.GetCountAsync(tagId,searchText);
            return (int)Math.Ceiling((decimal)(blogCount) / take);
        }

        public IActionResult Detail()
        {
            return View();
        }


    }
}
