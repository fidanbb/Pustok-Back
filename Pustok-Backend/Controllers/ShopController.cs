using Microsoft.AspNetCore.Mvc;
using Pustok_Backend.Areas.Admin.ViewModels.Blog;
using Pustok_Backend.Areas.Admin.ViewModels.Category;
using Pustok_Backend.Areas.Admin.ViewModels.Product;
using Pustok_Backend.Areas.Admin.ViewModels.Tag;
using Pustok_Backend.Helpers;
using Pustok_Backend.Services;
using Pustok_Backend.Services.Interfaces;
using Pustok_Backend.ViewModels;

namespace Pustok_Backend.Controllers
{
    public class ShopController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ShopController(IProductService productService,
                               ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;

        }
        [HttpGet]
        public async Task<IActionResult> Index(int page = 1, int take = 9, int? categoryId=null, string sortValue = null, string searchText = null, int? minValue = null, int? maxValue=null)
        {
            List<ProductVM> dbPaginatedDatas = await _productService.GetPaginatedDatasAsync(page, take, categoryId,sortValue,searchText,minValue,maxValue);
            
            int pageCount = await GetPageCountAsync(take, categoryId, sortValue, searchText,minValue,maxValue);

            Paginate<ProductVM> paginatedDatas = new(dbPaginatedDatas, page, pageCount);
            List<CategoryVM> categories = await _categoryService.GetAllAsync();
          
            ViewBag.take = take;
            ViewBag.TotalProduct = await _productService.GetTotalProductCountAsync();

            ShopVM model = new()
            {
                PaginatedDatas = paginatedDatas,
                Categories = categories
             
            };

            return View(model);
        }

        private async Task<int> GetPageCountAsync(int take, int? categoryId, string sortValue, string searchText, int? minValue, int? maxValue)
        {
            int productCount = await _productService.GetCountAsync(categoryId, sortValue, searchText,minValue,maxValue);
            return (int)Math.Ceiling((decimal)(productCount) / take);
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}
