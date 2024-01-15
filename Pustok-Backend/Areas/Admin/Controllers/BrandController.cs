using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pustok_Backend.Areas.Admin.ViewModels.Brand;
using Pustok_Backend.Helpers.Extensions;
using Pustok_Backend.Services;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {

            try
            {
                ICollection<BrandVM> brands = await _brandService.GetAllAsync();

                return View(brands);
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
                if (id is null) throw new ArgumentNullException();

                BrandVM dbBrand = await _brandService.GetByIdAsync((int)id);

                if (dbBrand is null) throw new NullReferenceException();

                return View(dbBrand);
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
        public async Task<IActionResult> Create(BrandCreateVM request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                foreach (var photo in request.Photos)
                {
                    if (!photo.CheckFileType("image/"))
                    {
                        ModelState.AddModelError("Photos", "File can be only image format");
                        return View();
                    }
                    if (!photo.CheckFileSize(200))
                    {
                        ModelState.AddModelError("Photos", "File size can be max 200 kb");
                        return View();
                    }
                }

                await _brandService.CreateAsync(request);

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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _brandService.DeleteAsync((int)id);


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

                BrandVM brand = await _brandService.GetByIdAsync((int)id);
                if (brand is null) throw new NullReferenceException();

                return View(new BrandEditVM
                {
                    Image = brand.Image
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
        public async Task<IActionResult> Edit(int? id, BrandEditVM request)
        {
            try
            {
                if (id is null) throw new ArgumentNullException();

                BrandVM dbBrand = await _brandService.GetByIdAsync((int)id);
                if (dbBrand is null) throw new NullReferenceException();


                request.Image = dbBrand.Image;

                if (request.Photo is null)
                {
                    return RedirectToAction(nameof(Index));
                }
                if (!request.Photo.CheckFileType("image/"))
                {
                    ModelState.AddModelError("Photo", "File can be only image format");
                    return View(request);
                }

                if (!request.Photo.CheckFileSize(200))
                {
                    ModelState.AddModelError("Photo", "File size can be max 200 kb");
                    return View(request);
                }

                await _brandService.EditAsync(request);

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

