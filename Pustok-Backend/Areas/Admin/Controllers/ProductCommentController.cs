using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pustok_Backend.Areas.Admin.ViewModels.BlogComment;
using Pustok_Backend.Areas.Admin.ViewModels.ProductComment;
using Pustok_Backend.Helpers;
using Pustok_Backend.Services;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class ProductCommentController : Controller
    {
        private readonly IProductCommentService _productCommentService;

        public ProductCommentController(IProductCommentService productCommentService)
        {
                _productCommentService = productCommentService;
        }
        [HttpGet]
        public async Task<IActionResult> Index(int page = 1, int take = 5)
        {
            try
            {
                List<ProductCommentVM> dbPaginatedDatas = await _productCommentService.GetAllAsync(page,take);

                int pageCount = await GetPageCountAsync(take);
                Paginate<ProductCommentVM> paginatedDatas = new(dbPaginatedDatas, page, pageCount);
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
            int commentCount = await _productCommentService.GetCountAsync();

            return (int)Math.Ceiling((decimal)(commentCount) / take);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            try
            {
                if (id is null) throw new ArgumentNullException();

                ProductCommentVM dbComment = await _productCommentService.GetByIdAsync((int)id);

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

                ProductCommentVM dbComment = await _productCommentService.GetByIdAsync((int)id);

                if (dbComment is null) throw new NullReferenceException();
                await _productCommentService.DeleteAsync((int)id);
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
