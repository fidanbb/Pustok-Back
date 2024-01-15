using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class SubscribeController : Controller
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                return View(await _subscribeService.GetAllAsync());
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
                if(id is null ) throw new ArgumentNullException();
                await _subscribeService.DeleteAsync((int)id);
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
