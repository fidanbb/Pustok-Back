using MailKit.Search;
using Microsoft.AspNetCore.Mvc;
using Pustok_Backend.Areas.Admin.ViewModels.Blog;
using Pustok_Backend.Areas.Admin.ViewModels.Social;
using Pustok_Backend.Areas.Admin.ViewModels.Tag;
using Pustok_Backend.Helpers;
using Pustok_Backend.Models;
using Pustok_Backend.Services.Interfaces;
using Pustok_Backend.ViewModels;
using System.Collections.Generic;

namespace Pustok_Backend.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ITagService _tagService;
        private readonly ISocialService _socialService;
        public BlogController(IBlogService blogService,
                              ITagService tagService,
                              ISocialService socialService)
        {
            _blogService = blogService;
            _tagService = tagService;
            _socialService = socialService;

        }
        public async Task<IActionResult> Index(int page = 1, int take = 6,int? tagId=null,string searchText=null)
        {
            List<BlogVM> dbPaginatedDatas = await _blogService.GetPaginatedDatasAsync(page, take,tagId,searchText);

            int pageCount = await GetPageCountAsync(take,tagId,searchText);

            Paginate<BlogVM> paginatedDatas = new(dbPaginatedDatas, page, pageCount);
            List<TagVM> tags=await _tagService.GetAllAsync();
            List<BlogVM> latestBlogs = await _blogService.GetAllWithTakeInDescendingOrderAsync(4);

            BlogPageVM model = new()
            {
                PaginatedDatas = paginatedDatas,
                Tags = tags,
                LatestBlogs = latestBlogs
            };

            return View(model);
        }

        private async Task<int> GetPageCountAsync(int take, int? tagId, string searchText)
        {
            int blogCount = await _blogService.GetCountAsync(tagId,searchText);
            return (int)Math.Ceiling((decimal)(blogCount) / take);
        }


        [HttpGet]
        public async Task<IActionResult> GetBlogsByTag(int? id, int page = 1, int take = 6)
        {
            try
            {
                if (id is null) throw new ArgumentNullException();

                var blogs = await _blogService.GetPaginatedDatasAsync(page, take, (int)id, null);

                int pageCount = await GetPageCountAsync(take, (int)id, null);

                Paginate<BlogVM> model = new(blogs, page, pageCount);

                return PartialView("_BlogsPartial", model);
            }
            catch (ArgumentNullException)
            {

                return BadRequest();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
           
        }


        [HttpGet]
        public async Task<IActionResult> SearchBlogs(string searchText, int page = 1, int take = 6)
        {
            try
            {
                
                var blogs = await _blogService.GetPaginatedDatasAsync(page, take, null, searchText);

                int pageCount = await GetPageCountAsync(take, null, searchText);

                Paginate<BlogVM> model = new(blogs, page, pageCount);

                return PartialView("_BlogsPartial", model);
            }
            catch (ArgumentNullException)
            {

                return BadRequest();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }

        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            try
            {
                if(id is null) throw new ArgumentNullException();

                BlogDetailVM blog = await _blogService.GetByIdWithoutTrackingAsync((int)id);
                
                if(blog is null) throw new NullReferenceException();

                List<SocialVM> socials=await _socialService.GetAllAsync();
                List<BlogVM> latestBlogs = await _blogService.GetAllWithTakeInDescendingOrderAsync(4);
                List<BlogVM> relatedBlogs=await _blogService.GetRelatedDatasAsync(blog,2);
                List<TagVM> tags = await _tagService.GetAllAsync();
                List < (DateTime Month, int Count)> dates = await _blogService.GetDatesOfDatasAsync();

                BlogDetailPageVM model = new()
                {
                    Blog = blog,
                    Socials = socials,
                    LatestBlogs = latestBlogs,
                    RelatedBlogs = relatedBlogs,
                    Tags = tags,
                    Dates = dates
                };

                return View(model);
            }
            catch (ArgumentNullException)
            {

                return BadRequest();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }


    }
}
