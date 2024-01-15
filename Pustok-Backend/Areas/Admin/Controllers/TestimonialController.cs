using Microsoft.AspNetCore.Mvc;
using Pustok_Backend.Areas.Admin.ViewModels.Testimonial;
using Pustok_Backend.Services;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TestimonialController : Controller
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpGet]
        public  async Task< IActionResult> Index()
        {
            try
            {
              
                return View(await _testimonialService.GetAllAsync());
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
                if(id is null) throw new ArgumentNullException();

                TestimonialVM testimonial = await _testimonialService.GetByIdAsync((int)id);

                if (testimonial is null) throw new NullReferenceException();

                return View(testimonial);
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
        public async Task<IActionResult> Delete(int? id)
        {
            try
            {
                if(id is null) throw new ArgumentNullException();
                await _testimonialService.DeleteAsync((int)id);

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
