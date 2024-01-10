using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pustok_Backend.Areas.Admin.ViewModels.Advert;
using Pustok_Backend.Areas.Admin.ViewModels.Slider;
using Pustok_Backend.Helpers.Extensions;
using Pustok_Backend.Services;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class AdvertController : Controller
    {
        private readonly IAdvertService _advertService;
        private readonly IMapper _mapper;

        public AdvertController(IAdvertService advertService,
                                IMapper mapper)
        {
            _advertService = advertService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                List<AdvertVM> adverts=await _advertService.GetAllAsync();

                return View(adverts);
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

        public async Task<IActionResult>Detail(int? id)
        {
            try
            {
                if (id == null) throw new ArgumentNullException();

                AdvertVM dbAdvert = await _advertService.GetByIdWithoutTracking((int)id);

                if (dbAdvert == null) throw new NullReferenceException();

                return View(dbAdvert);
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

                AdvertVM dbAdvert = await _advertService.GetByIdWithoutTracking((int)id);

                if (dbAdvert is null) throw new NullReferenceException();

                AdvertEditVM advert = _mapper.Map<AdvertEditVM>(dbAdvert);

                return View(advert);
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

        public async Task<IActionResult> Edit(int? id, AdvertEditVM request)
        {
            try
            {
                if (id is null) throw new ArgumentNullException();

                AdvertVM dbAdvert = await _advertService.GetByIdWithoutTracking((int)id);

                if (dbAdvert is null) throw new NullReferenceException();

                request.Image = dbAdvert.Image;

                if (id!=1 && id!=2)
                {

                    if (!ModelState.IsValid)
                    {
                        return View(request);
                    }
                }


                if (request.Photo is null)
                {
                    await _advertService.EditAsync(request);
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


                await _advertService.EditAsync(request);

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
