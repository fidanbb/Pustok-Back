using Microsoft.AspNetCore.Mvc;
using Pustok_Backend.Areas.Admin.ViewModels.Advert;
using Pustok_Backend.Areas.Admin.ViewModels.Brand;
using Pustok_Backend.Areas.Admin.ViewModels.Service;
using Pustok_Backend.Areas.Admin.ViewModels.Slider;
using Pustok_Backend.Services.Interfaces;
using Pustok_Backend.ViewModels;
using System.Diagnostics;

namespace Pustok_Backend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly ISiteServicesService _siteServicesService;
        private readonly IAdvertService _advertService;
        private readonly IBrandService _brandService;

        public HomeController(ISliderService sliderService,
                               ISiteServicesService siteServicesService,
                               IAdvertService advertService,
                               IBrandService brandService)
        {
                _sliderService = sliderService;
            _siteServicesService = siteServicesService;
            _advertService = advertService;
            _brandService = brandService;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                List<SliderVM> sliders = await _sliderService.GetAllAsync();
                ICollection<ServiceVM> siteServices = await _siteServicesService.GetAllAsync();
                List<AdvertVM> adverts = await _advertService.GetAllAsync();
                ICollection <BrandVM> brands =await _brandService.GetAllAsync();


                HomeVM model = new()
                {
                    Sliders = sliders,
                    SiteServices = siteServices,
                    Adverts = adverts,
                    Brands = brands
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
    }
}
