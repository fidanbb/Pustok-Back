using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pustok_Backend.Areas.Admin.ViewModels.Blog;
using Pustok_Backend.Areas.Admin.ViewModels.Product;
using Pustok_Backend.Helpers;
using Pustok_Backend.Helpers.Extensions;
using Pustok_Backend.Services;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IAuthorService _authorService;
        private readonly  ICategoryService _categoryService;
        private readonly IDiscountService _discountService;
        private readonly ITagService _tagService;
        public ProductController(IProductService productService,
                                  IAuthorService authorService, 
                                  ICategoryService categoryService, 
                                  IDiscountService discountService,
                                  ITagService tagService)
        {
            _productService = productService;
            _authorService = authorService;
            _categoryService = categoryService;
            _discountService = discountService;
            _tagService = tagService;

        }
        [HttpGet]
        public async Task<IActionResult> Index(int page = 1, int take = 5)
        {
            try
            {
                List<ProductVM> dbPaginatedDatas = await _productService.GetPaginatedProductDatasAsync(page, take);

                int pageCount = await GetPageCountAsync(take);
                Paginate<ProductVM> paginatedDatas = new(dbPaginatedDatas, page, pageCount);

                TempData["CurrentPage"] = page;
                //TempData["CurrentPageForAction"] = page;
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
            int productCount = await _productService.GetTotalProductCountAsync();

            return (int)Math.Ceiling((decimal)(productCount) / take);
        }

        [HttpGet]

        public async Task<IActionResult> Detail(int? id)
        {
            try
            {
                if (id == null) throw new ArgumentNullException();

                ProductDetailVM dbProduct = await _productService.GetByIdWithoutTrackingAsync((int)id);

                if (dbProduct is null) throw new NullReferenceException();

                return View(dbProduct);
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

                ProductDetailVM dbProduct = await _productService.GetByIdWithoutTrackingAsync((int)id);

                if (dbProduct is null) throw new NullReferenceException();

                await _productService.DeleteAsync((int)id);

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
                ViewBag.authors = await GetAuthorsAsync();
                ViewBag.categories = await GetCategoriesAsync();
                ViewBag.discounts = await GetDiscountsAsync();
                var tags = _tagService.GetAllTagsAsync();

                ProductCreateVM viewModel = new ProductCreateVM
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

        public async Task<IActionResult> Create(ProductCreateVM request)
        {
            try
            {
                ViewBag.authors = await GetAuthorsAsync();
                ViewBag.categories = await GetCategoriesAsync();
                ViewBag.discounts = await GetDiscountsAsync();

                if (!ModelState.IsValid)
                {
                    request.Tags = _tagService.GetAllTagsAsync();
                    return View(request);
                }

                ProductVM existProduct = await _productService.GetByNameWithoutTrackingAsync(request.Name);

                if (existProduct is not null)
                {
                    ModelState.AddModelError("Name", "This title already exists");

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


                await _productService.CreateAsync(request);
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
                ViewBag.authors = await GetAuthorsAsync();
                ViewBag.categories = await GetCategoriesAsync();
                ViewBag.discounts = await GetDiscountsAsync();

                if (id is null) throw new ArgumentNullException();

                ProductDetailVM dbProduct = await _productService.GetByIdWithoutTrackingAsync((int)id);

                if (dbProduct is null) throw new NullReferenceException();


                var selectedTags = dbProduct.ProductTags.Select(m => m.TagId).ToList();

                var tags = _tagService.GetAllSelectedTagsAsync(selectedTags);

                return View(new ProductEditVM()
                {
                    Name = dbProduct.Name,
                    Description = dbProduct.Description,
                    Price = dbProduct.Price,
                    Sku= dbProduct.Sku,
                    StockCount = dbProduct.StockCount,
                    Images = dbProduct.Images,
                    Tags = tags

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

        public async Task<IActionResult> Edit(int? id, ProductEditVM request)
        {
            try
            {
                if (id is null) throw new ArgumentNullException();

                ProductDetailVM dbProduct = await _productService.GetByIdWithoutTrackingAsync((int)id);

                if (dbProduct is null) throw new NullReferenceException();

                var selectedTags = dbProduct.ProductTags.Select(m => m.TagId).ToList();

                request.Images = dbProduct.Images;

                foreach (var item in request.Tags)
                {
                }

                if (!ModelState.IsValid)
                {
                    return View(request);
                }


                ProductVM existProduct = await _productService.GetByNameWithoutTrackingAsync(request.Name);


                if (request.Photos != null)
                {
                    foreach (var photo in request.Photos)
                    {
                        if (!photo.CheckFileType("image/"))
                        {
                            ModelState.AddModelError("Photos", "File can only be in image format");
                            return View(request);

                        }

                        if (!photo.CheckFileSize(200))
                        {
                            ModelState.AddModelError("Photos", "File size can be max 200 kb");
                            return View(request);
                        }

                    }
                }


                if (existProduct is not null)
                {
                    if (existProduct.Id == request.Id)
                    {
                        await _productService.EditAsync(request);

                        return RedirectToAction(nameof(Index));
                    }

                    ModelState.AddModelError("Name", "This product title already exists");
                    return View(request);
                }
                await _productService.EditAsync(request);

                //var currentPage = TempData["CurrentPageForAction"];

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

        public async Task<IActionResult> DeleteProductImage(int id)
        {
            await _productService.DeleteProductImageAsync(id);

            return Ok();
        }


        private async Task<SelectList> GetAuthorsAsync()
        {
            return new SelectList(await _authorService.GetAllAsync(), "Id", "FullName");
        }

        private async Task<SelectList> GetCategoriesAsync()
        {
            return new SelectList(await _categoryService.GetAllAsync(), "Id", "Name");
        }

        private async Task<SelectList> GetDiscountsAsync()
        {
            return new SelectList(await _discountService.GetAllAsync(), "Id", "Name");
        }

    }
}
