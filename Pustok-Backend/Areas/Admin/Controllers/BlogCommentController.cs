using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pustok_Backend.Areas.Admin.ViewModels.BlogAuthor;
using Pustok_Backend.Areas.Admin.ViewModels.BlogComment;
using Pustok_Backend.Helpers;
using Pustok_Backend.Services;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class BlogCommentController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogCommentController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        [HttpGet]
        public async Task<IActionResult> Index(int page = 1, int take = 5)
        {
            try
            {
                List<BlogCommentVM> dbPaginatedDatas = await _blogService.GetCommentsAsync(page, take);

                int pageCount = await GetPageCountAsync(take);
                Paginate<BlogCommentVM> paginatedDatas = new(dbPaginatedDatas, page, pageCount);
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
            int commentCount = await _blogService.GetCommentCountAsync();

            return (int)Math.Ceiling((decimal)(commentCount) / take);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            try
            {
                if (id is null) throw new ArgumentNullException();

                BlogCommentVM dbComment = await _blogService.GetCommentByIdAsync((int)id);

                if (dbComment is null) throw new NullReferenceException();

                return View(dbComment);
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

                BlogCommentVM dbComment = await _blogService.GetCommentByIdAsync((int)id);

                if (dbComment is null) throw new NullReferenceException();
                await _blogService.DeleteCommentAsync((int)id);
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
