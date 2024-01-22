using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pustok_Backend.Areas.Admin.ViewModels.Author;
using Pustok_Backend.Areas.Admin.ViewModels.Category;
using Pustok_Backend.Helpers;
using Pustok_Backend.Services;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> Index(int page = 1, int take = 5)
        {
            try
            {
                List<CategoryVM> dbPaginatedDatas = await _categoryService.GetPaginatedDatasAsync(page, take);

                int pageCount = await GetPageCountAsync(take);
                Paginate<CategoryVM> paginatedDatas = new(dbPaginatedDatas, page, pageCount);
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
            int categoryCount = await _categoryService.GetCountAsync();

            return (int)Math.Ceiling((decimal)(categoryCount) / take);
        }


        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            try
            {
                if (id is null) throw new ArgumentNullException();

                CategoryVM dbCategory = await _categoryService.GetByIdWithoutTrackingAsync((int)id);

                if (dbCategory is null) throw new NullReferenceException();

                return View(dbCategory);
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

        public async Task<IActionResult> Create(CategoryCreateVM request)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    return View();
                }

                CategoryVM existCategory = await _categoryService.GetByNameWithoutTrackingAsync(request.Name);

                if (existCategory != null)
                {
                    ModelState.AddModelError("Name", "This Category already exists");
                    return View();
                }


                await _categoryService.CreateAsync(request);

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

                CategoryVM category = await _categoryService.GetByIdWithoutTrackingAsync((int)id);

                if (category is null) throw new NullReferenceException();
                await _categoryService.DeleteAsync((int)id);
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

                CategoryVM dbCategory = await _categoryService.GetByIdWithoutTrackingAsync((int)id);

                if (dbCategory is null) throw new NullReferenceException();

                return View(new CategoryEditVM
                {
                    Name = dbCategory.Name
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

        public async Task<IActionResult> Edit(int? id, CategoryEditVM request)
        {
            try
            {
                if (id is null) throw new ArgumentNullException();

                CategoryVM dbCategory = await _categoryService.GetByIdWithoutTrackingAsync((int)id);

                if (dbCategory is null) throw new NullReferenceException();


                if (!ModelState.IsValid)
                {
                    return View();
                }

                CategoryVM existCategory = await _categoryService.GetByNameWithoutTrackingAsync(request.Name);



                if (existCategory != null)
                {
                    if (existCategory.Id == request.Id)
                    {
                        await _categoryService.EditAsync(request);

                        return RedirectToAction(nameof(Index));
                    }

                    ModelState.AddModelError("Name", "This Category already exists");
                    return View();
                }

                await _categoryService.EditAsync(request);

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
