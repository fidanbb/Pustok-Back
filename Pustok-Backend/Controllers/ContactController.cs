using Microsoft.AspNetCore.Mvc;
using Pustok_Backend.Areas.Admin.ViewModels.Brand;
using Pustok_Backend.Areas.Admin.ViewModels.Contact;
using Pustok_Backend.Areas.Admin.ViewModels.Social;
using Pustok_Backend.Services;
using Pustok_Backend.Services.Interfaces;
using Pustok_Backend.ViewModels;

namespace Pustok_Backend.Controllers
{
    public class ContactController : Controller
    {
        private readonly IBrandService _brandService;
        private readonly ISocialService _socialService;
        private readonly ISettingService _settingService;
        private readonly IContactService _contactService;

        public ContactController(IBrandService brandService,
                                 ISocialService socialService,
                                 ISettingService settingService,
                                 IContactService contactService)
        {
            _brandService = brandService;
            _socialService = socialService;
            _settingService = settingService;
            _contactService = contactService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {

            try
            {
                ICollection<BrandVM> brands=await _brandService.GetAllAsync();
                List<SocialVM> socials=await _socialService.GetAllAsync();
                Dictionary<string, string> settings =  _settingService.GetSettings();

                ContactVM model = new()
                {
                    Brands = brands,
                    Socials = socials,
                    Settings = settings
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

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> SendMessage(ContactMessageCreateVM request)
        {

            try
            {
                if (!ModelState.IsValid) return RedirectToAction("Index");

                await _contactService.CreateAsync(request);

                return RedirectToAction("Index");
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
