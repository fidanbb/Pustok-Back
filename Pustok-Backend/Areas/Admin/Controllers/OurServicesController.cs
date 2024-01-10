using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pustok_Backend.Areas.Admin.ViewModels.Service;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class OurServicesController : Controller
    {
        private readonly ISiteServicesService _siteServicesService;
        private readonly IMapper _mapper;

        public OurServicesController(ISiteServicesService siteServicesService,
                                      IMapper mapper)
        {
                _siteServicesService = siteServicesService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                ICollection<ServiceVM> services=await _siteServicesService.GetAllAsync();
                return View(services);
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

                ServiceVM dbService = await _siteServicesService.GetByIdWithoutTracking((int)id);

                if (dbService is null) throw new NullReferenceException();

                return View(dbService);
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

                ServiceVM dbService = await _siteServicesService.GetByIdWithoutTracking((int)id);
                if (dbService is null) throw new NullReferenceException();

                return View(_mapper.Map<ServiceEditVM>(dbService));
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
        public async Task<IActionResult> Edit(int? id, ServiceEditVM request)
        {
            try
            {
                if (id is null) throw new ArgumentNullException();

                ServiceVM dbService = await _siteServicesService.GetByIdWithoutTracking((int)id);
                if (dbService is null) throw new NullReferenceException();

                if (!ModelState.IsValid)
                {
                    return View();
                }

                await _siteServicesService.EditAsync(request);

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
