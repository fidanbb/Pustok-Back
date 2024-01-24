using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pustok_Backend.Areas.Admin.ViewModels.Author;
using Pustok_Backend.Areas.Admin.ViewModels.Category;
using Pustok_Backend.Areas.Admin.ViewModels.Discount;
using Pustok_Backend.Helpers;
using Pustok_Backend.Services;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class DiscountController : Controller
    {
        private readonly IDiscountService _discountService;

        public DiscountController(IDiscountService discountService)
        {
            _discountService = discountService;
        }
        [HttpGet]
        public async Task<IActionResult> Index(int page = 1, int take = 5)
        {
            try
            {
                List<DiscountVM> dbPaginatedDatas = await _discountService.GetPaginatedDatasAsync(page, take);

                int pageCount = await GetPageCountAsync(take);
                Paginate<DiscountVM> paginatedDatas = new(dbPaginatedDatas, page, pageCount);
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
            int discountCount = await _discountService.GetCountAsync();

            return (int)Math.Ceiling((decimal)(discountCount) / take);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            try
            {
                if (id is null) throw new ArgumentNullException();

                DiscountVM dbDiscount = await _discountService.GetByIdWithoutTrackingAsync((int)id);

                if (dbDiscount is null) throw new NullReferenceException();

                return View(dbDiscount);
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

        public async Task<IActionResult> Create(DiscountCreateVM request)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    return View();
                }

                DiscountVM existDiscount = await _discountService.GetByNameWithoutTrackingAsync(request.Name);

                if (existDiscount != null)
                {
                    ModelState.AddModelError("Name", "This Discount already exists");
                    return View();
                }


                await _discountService.CreateAsync(request);

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

                DiscountVM discount = await _discountService.GetByIdWithoutTrackingAsync((int)id);

                if (discount is null) throw new NullReferenceException();
                await _discountService.DeleteAsync((int)id);
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

                DiscountVM dbDiscount = await _discountService.GetByIdWithoutTrackingAsync((int)id);

                if (dbDiscount is null) throw new NullReferenceException();

                return View(new DiscountEditVM
                {
                    Name = dbDiscount.Name,
                    Percent =dbDiscount.Percent,
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

        public async Task<IActionResult> Edit(int? id, DiscountEditVM request)
        {
            try
            {
                if (id is null) throw new ArgumentNullException();

                DiscountVM dbDiscount = await _discountService.GetByIdWithoutTrackingAsync((int)id);

                if (dbDiscount is null) throw new NullReferenceException();


                if (!ModelState.IsValid)
                {
                    return View();
                }

                DiscountVM existDiscount = await _discountService.GetByNameWithoutTrackingAsync(request.Name);



                if (existDiscount != null)
                {
                    if (existDiscount.Id == request.Id)
                    {
                        await _discountService.EditAsync(request);

                        return RedirectToAction(nameof(Index));
                    }

                    ModelState.AddModelError("Name", "This Discount already exists");
                    return View();
                }

                await _discountService.EditAsync(request);

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
