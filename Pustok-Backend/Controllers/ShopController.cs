using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using Pustok_Backend.Areas.Admin.ViewModels.Category;
using Pustok_Backend.Areas.Admin.ViewModels.Product;
using Pustok_Backend.Areas.Admin.ViewModels.ProductComment;
using Pustok_Backend.Helpers;
using Pustok_Backend.Models;
using Pustok_Backend.Services;
using Pustok_Backend.Services.Interfaces;
using Pustok_Backend.ViewModels;

namespace Pustok_Backend.Controllers
{
    public class ShopController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IProductCommentService _productCommentService;
        private readonly IWishlistService _wishlistService;
        private readonly ICartService _cartService;

        public ShopController(IProductService productService,
                               ICategoryService categoryService,
                               IProductCommentService productCommentService,
                               IWishlistService wishlistService,
                               ICartService cartService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _productCommentService = productCommentService;
            _wishlistService = wishlistService;
            _cartService = cartService;

        }
        [HttpGet]
        public async Task<IActionResult> Index(int page = 1, int take = 9, int? categoryId=null, string sortValue = null, string searchText = null, int? minValue = null, int? maxValue=null)
        {
            List<ProductVM> dbPaginatedDatas = await _productService.GetPaginatedDatasAsync(page, take, categoryId,sortValue,searchText,minValue,maxValue);
            
            int pageCount = await GetPageCountAsync(take, categoryId, sortValue, searchText,minValue,maxValue);

            Paginate<ProductVM> paginatedDatas = new(dbPaginatedDatas, page, pageCount);
            List<CategoryVM> categories = await _categoryService.GetAllAsync();
            List<ProductVM> topProducts = await _productService.GetTopProducts(3);
            ProductDetailVM product = null;
           
            ViewBag.take = take;
            ViewBag.TotalProduct = await _productService.GetTotalProductCountAsync();

            ShopVM model = new()
            {
                PaginatedDatas = paginatedDatas,
                Categories = categories,
                TopProducts = topProducts,
             
            };

            return View(model);
        }

        private async Task<int> GetPageCountAsync(int take, int? categoryId, string sortValue, string searchText, int? minValue, int? maxValue)
        {
            int productCount = await _productService.GetCountAsync(categoryId, sortValue, searchText,minValue,maxValue);
            return (int)Math.Ceiling((decimal)(productCount) / take);
        }

        [HttpGet]
        public async Task<IActionResult> GetProductsByCategory(int? id, int page = 1, int take = 9)
        {
            try
            {
                ViewBag.take = take;
                ViewBag.TotalProduct = await _productService.GetTotalProductCountAsync();
                if (id is null) throw new ArgumentNullException();

                var products = await _productService.GetPaginatedDatasAsync(page, take, (int)id, null, null,null,null);

                int pageCount = await GetPageCountAsync(take, (int)id, null, null,null,null);

                Paginate<ProductVM> model = new(products, page, pageCount);

                return PartialView("_ProductsPartial", model);
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
        public async Task<IActionResult> GetProductsByRange(int? minValue, int? maxValue, int page = 1, int take = 9)
        {
            try
            {
                ViewBag.take = take;
                ViewBag.TotalProduct = await _productService.GetTotalProductCountAsync();
                if (minValue is null || maxValue is null) throw new ArgumentNullException();

                var products = await _productService.GetPaginatedDatasAsync(page, take, null, null, null, minValue, maxValue);

                int pageCount = await GetPageCountAsync(take, null, null, null, minValue, maxValue);

                Paginate<ProductVM> model = new(products, page, pageCount);

                return PartialView("_ProductsPartial", model);
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
        public async Task<IActionResult> GetProductsBySort(string sortValue, int page = 1, int take = 9)
        {
            try
            {
                ViewBag.take = take;
                ViewBag.TotalProduct = await _productService.GetTotalProductCountAsync();

                var products = await _productService.GetPaginatedDatasAsync(page, take, null, sortValue, null, null, null);

                int pageCount = await GetPageCountAsync(take, null, sortValue, null, null, null);

                Paginate<ProductVM> model = new(products, page, pageCount);

                return PartialView("_ProductsPartial", model);
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
        public async Task<IActionResult> GetAll(int page = 1, int take = 9)
        {
            try
            {
                ViewBag.take = take;
                ViewBag.TotalProduct = await _productService.GetTotalProductCountAsync();

                var products = await _productService.GetPaginatedDatasAsync(page, take, null, null, null, null, null);

                int pageCount = await GetPageCountAsync(take, null, null, null, null, null);

                Paginate<ProductVM> model = new(products, page, pageCount);

                return PartialView("_ProductsPartial", model);
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


        public async Task<IActionResult> Detail(int? id)
        {
            try
            {
                if(id is null) throw new ArgumentNullException();

                ProductDetailVM product = await _productService.GetByIdWithoutTrackingAsync((int)id);
                List<ProductVM> relatedProducts = await _productService.GetRelatedDatasAsync(product,3);

                if(product is null) throw new NullReferenceException();

                ProductDetailPageVM model = new()
                {
                    Product = product,
                    RelatedProducts = relatedProducts
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]

        public async Task<IActionResult> PostComment(ProductCommentCreateVM productComment, string userId, int? productId)
        {
            try
            {
                if (userId is null || productId is null) throw new ArgumentNullException();

                if (!ModelState.IsValid) return RedirectToAction(nameof(Detail), new { id = productId });

                ProductComment newProductComment = new()
                {
                    AppUserId = userId,
                    ProductId = (int)productId,
                    Message = productComment.Message,
                    Rate=productComment.Rate,
                };

                await _productCommentService.CreateAsync(newProductComment);

                return RedirectToAction(nameof(Detail), new { id = productId });
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

        public async Task<IActionResult> AddWishlist(int? id)
        {

            try
            {
                if (id is null) throw new ArgumentNullException();

                ProductDetailVM product = await _productService.GetByIdWithoutTrackingAsync((int)id);

                if (product is null) throw new NullReferenceException();

                bool isInWishlist = _wishlistService.AddWishlist((int)id, product);

                return Ok(isInWishlist);
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

        public async Task<IActionResult> AddBasket(int? id)
        {
            try
            {
                if (id is null) throw new ArgumentNullException();

                ProductDetailVM product = await _productService.GetByIdWithoutTrackingAsync((int)id);

                if (product is null) throw new NullReferenceException();

                decimal grandTotal= await _cartService.AddBasket((int)id, product);


                return Ok(grandTotal);
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
