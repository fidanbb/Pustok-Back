using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pustok_Backend.Areas.Admin.ViewModels.Advert;
using Pustok_Backend.Areas.Admin.ViewModels.Slider;
using Pustok_Backend.Helpers.Extensions;
using Pustok_Backend.Services;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class SliderController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly IDirectionService _directionService;
        private readonly IMapper _mapper;

        public SliderController(ISliderService sliderService, 
                                IDirectionService directionService,
                                IMapper mapper)
        {
            _sliderService = sliderService;
            _directionService = directionService;
            _mapper = mapper;

        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                return View(await _sliderService.GetAllAsync());
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

                SliderVM dbSlider = await _sliderService.GetByIdWithoutTrackingAsync((int)id);


                if (dbSlider is null) throw new NullReferenceException();

                return View(dbSlider);
            }
            catch (ArgumentNullException)
            {

                return BadRequest();
            }

            catch (NullReferenceException)
            {
                return NotFound();

            }
            //catch (InternalServerException)
            //{
            //    return StatusCode(500);
            //}


        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            try
            {
                ViewBag.directions = await GetDirectionsAsync();
                return View();
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

        public async Task<IActionResult> Create(SliderCreateVM request)
        {
            try
            {
                ViewBag.directions = await GetDirectionsAsync();

                if (!ModelState.IsValid)
                {
                    return View(request);
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

                await _sliderService.CreateAsync(request);

                return RedirectToAction(nameof(Index));
            }
            catch (ArgumentNullException)
            {
                return BadRequest();
            }

            catch (NullReferenceException)
            {
                return StatusCode(404);
            }
           
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            try
            {
                await _sliderService.DeleteAsync((int)id);


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
                ViewBag.directions = await GetDirectionsAsync();
                if (id is null) throw new ArgumentNullException();

                SliderVM dbSlider = await _sliderService.GetByIdWithoutTrackingAsync((int)id);

                if (dbSlider is null) throw new NullReferenceException();

                SliderEditVM slider = _mapper.Map<SliderEditVM>(dbSlider);

                return View(slider);
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

        public async Task<IActionResult> Edit(int? id, SliderEditVM request)
        {
            try
            {
                ViewBag.directions = await GetDirectionsAsync();
                if (id is null) throw new ArgumentNullException();

                SliderVM dbSlider = await _sliderService.GetByIdWithoutTrackingAsync((int)id);

                if (dbSlider is null) throw new NullReferenceException();

                request.Image = dbSlider.Image;

                if (!ModelState.IsValid)
                {
                    return View(request);
                }

                if (request.Photo is null)
                {
                    await _sliderService.EditAsync(request);
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


                await _sliderService.EditAsync(request);

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


        private async Task<SelectList> GetDirectionsAsync()
        {
           
                return new SelectList(await _directionService.GetAllAsync(), "Id", "Name");

         
        }


    }
}
