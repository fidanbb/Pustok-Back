using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pustok_Backend.Areas.Admin.ViewModels.Blog;
using Pustok_Backend.Areas.Admin.ViewModels.Tag;
using Pustok_Backend.Helpers;
using Pustok_Backend.Helpers.Extensions;
using Pustok_Backend.Services;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ITagService _tagService;
        private readonly IBlogAuthorService _blogAuthorService;

        public BlogController(IBlogService blogService,
                               ITagService tagService,
                              IBlogAuthorService blogAuthorService)
        {
            _blogService = blogService;
            _tagService = tagService;
            _blogAuthorService = blogAuthorService;

        }

        [HttpGet]
        public async Task<IActionResult> Index(int page = 1, int take = 5)
        {
            try
            {
                List<BlogVM> dbPaginatedDatas = await _blogService.GetPaginatedBlogDatasAsync(page, take);

                int pageCount = await GetPageCountAsync(take);
                Paginate<BlogVM> paginatedDatas = new(dbPaginatedDatas, page, pageCount);
                return View(paginatedDatas);
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

        public async Task<int> GetPageCountAsync(int take)
        {
            int blogCount = await _blogService.GetBlogCountAsync();

            return (int)Math.Ceiling((decimal)(blogCount) / take);
        }

        [HttpGet]

        public async Task<IActionResult> Detail(int? id)
        {
            try
            {
                if (id == null) throw new ArgumentNullException();

                BlogDetailVM dbBlog = await _blogService.GetByIdWithoutTrackingAsync((int)id);

                if (dbBlog is null) throw new NullReferenceException();

                return View(dbBlog);
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

        [HttpPost]

        public async Task<IActionResult> Delete(int? id)
        {
            try
            {
                if (id == null) throw new ArgumentNullException();

                BlogDetailVM dbBlog = await _blogService.GetByIdWithoutTrackingAsync((int)id);

                if (dbBlog is null) throw new NullReferenceException();

                await _blogService.DeleteAsync((int)id);

                return RedirectToAction(nameof(Index));
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
        public async Task<IActionResult> Create()
        {
            try
            {
                ViewBag.blogAuthors = await GetAuthorsAsync();
                var tags = _tagService.GetAllSelectedTagsAsync();

                BlogCreateVM viewModel = new BlogCreateVM
                {
                    Tags = tags
                };

                return View(viewModel);
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

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(BlogCreateVM request)
        {
            try
            {
                ViewBag.blogAuthors = await GetAuthorsAsync();

                if (!ModelState.IsValid)
                {
                    request.Tags= _tagService.GetAllSelectedTagsAsync();
                    return View(request);
                }

                BlogVM existBlog = await _blogService.GetByNameWithoutTrackingAsync(request.Title);

                if (existBlog is not null)
                {
                    ModelState.AddModelError("Title", "This title already exists");

                    return View(request);
                }

                foreach (var photo in request.Photos)
                {

                    if (!photo.CheckFileType("image/"))
                    {
                        ModelState.AddModelError("Photos", "File can be only image format");
                        return View(request);
                    }

                    if (!photo.CheckFileSize(200))
                    {
                        ModelState.AddModelError("Photos", "File size can be max 200 kb");
                        return View(request);
                    }
                }


                await _blogService.CreateAsync(request);
                return RedirectToAction(nameof(Index));
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

        private async Task<SelectList> GetAuthorsAsync()
        {
            return new SelectList(await _blogAuthorService.GetAllAsync(), "Id", "FullName");
        }
    }
}
