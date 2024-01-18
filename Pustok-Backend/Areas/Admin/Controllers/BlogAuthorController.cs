using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Org.BouncyCastle.Crypto;
using Pustok_Backend.Areas.Admin.ViewModels.BlogAuthor;
using Pustok_Backend.Areas.Admin.ViewModels.Tag;
using Pustok_Backend.Helpers;
using Pustok_Backend.Services;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class BlogAuthorController : Controller
    {
        private readonly IBlogAuthorService _blogAuthorService;

        public BlogAuthorController(IBlogAuthorService blogAuthorService)
        {
            _blogAuthorService = blogAuthorService;
        }

        [HttpGet]
        public async Task< IActionResult> Index(int page=1,int take=5)
        {
            try
            {
                List<BlogAuthorVM> dbPaginatedDatas = await _blogAuthorService.GetPaginatedDatasAsync(page, take);

                int pageCount = await GetPageCountAsync(take);
                Paginate<BlogAuthorVM> paginatedDatas = new(dbPaginatedDatas, page, pageCount);
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
            int authorCount = await _blogAuthorService.GetCountAsync();

            return (int)Math.Ceiling((decimal)(authorCount) / take);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            try
            {
              if(id is null) throw new ArgumentNullException();

                BlogAuthorVM dbAuthor = await _blogAuthorService.GetByIdWithoutTrackingAsync((int)id);

                if(dbAuthor is null) throw new NullReferenceException();

                return View(dbAuthor);
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
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(BlogAuthorCreateVM request)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    return View();
                }

                BlogAuthorVM existBlogAuthor = await _blogAuthorService.GetByNameWithoutTrackingAsync(request.FullName);

                if (existBlogAuthor != null)
                {
                    ModelState.AddModelError("FullName", "This Author already exists");
                    return View();
                }


                await _blogAuthorService.CreateAsync(request);

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

        [HttpPost]

        public async Task<IActionResult> Delete(int? id)
        {
            try
            {
                if (id is null) throw new ArgumentNullException();

                BlogAuthorVM blogAuthor = await _blogAuthorService.GetByIdWithoutTrackingAsync((int)id);

                if (blogAuthor is null) throw new NullReferenceException();
                await _blogAuthorService.DeleteAsync((int)id);
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
        public async Task<IActionResult> Edit(int? id)
        {
            try
            {
                if (id is null) throw new ArgumentNullException();

                BlogAuthorVM dbBlogAuthor = await _blogAuthorService.GetByIdWithoutTrackingAsync((int)id);

                if (dbBlogAuthor is null) throw new NullReferenceException();

                return View(new BlogAuthorEditVM
                {
                    FullName = dbBlogAuthor.FullName
                });
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

        public async Task<IActionResult> Edit(int? id, BlogAuthorEditVM request)
        {
            try
            {
                if (id is null) throw new ArgumentNullException();

                BlogAuthorVM dbBlogAuthor = await _blogAuthorService.GetByIdWithoutTrackingAsync((int)id);

                if (dbBlogAuthor is null) throw new NullReferenceException();


                if (!ModelState.IsValid)
                {
                    return View();
                }

                BlogAuthorVM existBlogAuthor = await _blogAuthorService.GetByNameWithoutTrackingAsync(request.FullName);



                if (existBlogAuthor != null)
                {
                    if (existBlogAuthor.Id == request.Id)
                    {
                        await _blogAuthorService.EditAsync(request);

                        return RedirectToAction(nameof(Index));
                    }

                    ModelState.AddModelError("FullName", "This Author already exists");
                    return View();
                }

                await _blogAuthorService.EditAsync(request);

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


    }
}
