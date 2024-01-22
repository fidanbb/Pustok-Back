using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pustok_Backend.Areas.Admin.ViewModels.Author;
using Pustok_Backend.Areas.Admin.ViewModels.BlogAuthor;
using Pustok_Backend.Helpers;
using Pustok_Backend.Services;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class AuthorController : Controller
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }
        [HttpGet]
        public async Task<IActionResult> Index(int page = 1, int take = 5)
        {
            try
            {
                List<AuthorVM> dbPaginatedDatas = await _authorService.GetPaginatedDatasAsync(page, take);

                int pageCount = await GetPageCountAsync(take);
                Paginate<AuthorVM> paginatedDatas = new(dbPaginatedDatas, page, pageCount);
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
            int authorCount = await _authorService.GetCountAsync();

            return (int)Math.Ceiling((decimal)(authorCount) / take);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            try
            {
                if (id is null) throw new ArgumentNullException();

                AuthorVM dbAuthor = await _authorService.GetByIdWithoutTrackingAsync((int)id);

                if (dbAuthor is null) throw new NullReferenceException();

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

        public async Task<IActionResult> Create(AuthorCreateVM request)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    return View();
                }

                AuthorVM existAuthor = await _authorService.GetByNameWithoutTrackingAsync(request.FullName);

                if (existAuthor != null)
                {
                    ModelState.AddModelError("FullName", "This Author already exists");
                    return View();
                }


                await _authorService.CreateAsync(request);

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

                AuthorVM author = await _authorService.GetByIdWithoutTrackingAsync((int)id);

                if (author is null) throw new NullReferenceException();
                await _authorService.DeleteAsync((int)id);
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

                AuthorVM dbAuthor = await _authorService.GetByIdWithoutTrackingAsync((int)id);

                if (dbAuthor is null) throw new NullReferenceException();

                return View(new AuthorEditVM
                {
                    FullName = dbAuthor.FullName
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

        public async Task<IActionResult> Edit(int? id, AuthorEditVM request)
        {
            try
            {
                if (id is null) throw new ArgumentNullException();

                AuthorVM dbAuthor = await _authorService.GetByIdWithoutTrackingAsync((int)id);

                if (dbAuthor is null) throw new NullReferenceException();


                if (!ModelState.IsValid)
                {
                    return View();
                }

              AuthorVM existAuthor = await _authorService.GetByNameWithoutTrackingAsync(request.FullName);



                if (existAuthor != null)
                {
                    if (existAuthor.Id == request.Id)
                    {
                        await _authorService.EditAsync(request);

                        return RedirectToAction(nameof(Index));
                    }

                    ModelState.AddModelError("FullName", "This Author already exists");
                    return View();
                }

                await _authorService.EditAsync(request);

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
