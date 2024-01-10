using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pustok_Backend.Areas.Admin.ViewModels.Social;
using Pustok_Backend.Services;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SocialController : Controller
    {
        private readonly ISocialService _socialService;
        private readonly IMapper _mapper;

        public SocialController(ISocialService socialService,
                                IMapper mapper)
        {
            _socialService = socialService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                List<SocialVM> socials=await _socialService.GetAllAsync();
                return View(socials);
            }
            catch (ArgumentNullException)
            {

                return BadRequest();
            }

            catch(NullReferenceException)
            {
                return NotFound();
            }
         
        }

        [HttpGet]

        public async Task<IActionResult>Detail(int? id)
        {
            try
            {
                if (id is null) throw new ArgumentNullException();

                SocialVM dbSocial = await _socialService.GetByIdWithoutTrackingAsync((int)id);

                if(dbSocial is null) throw new NullReferenceException();

                return View(dbSocial);
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

                SocialVM dbSocial = await _socialService.GetByIdWithoutTrackingAsync((int)id);
                if (dbSocial is null) throw new NullReferenceException();

                return View(_mapper.Map<SocialEditVM>(dbSocial));
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
        public async Task<IActionResult> Edit(int? id, SocialEditVM request)
        {
            try
            {
                if (id is null) throw new ArgumentNullException();

                SocialVM dbSocial = await _socialService.GetByIdWithoutTrackingAsync((int)id);

                if (dbSocial is null) throw new NullReferenceException();

                if (!ModelState.IsValid)
                {
                    return View();
                }

                await _socialService.EditAsync(request);

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
