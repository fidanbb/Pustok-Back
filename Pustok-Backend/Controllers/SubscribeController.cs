using Microsoft.AspNetCore.Mvc;
using Pustok_Backend.Areas.Admin.ViewModels.Subscribe;
using Pustok_Backend.Services.Interfaces;
using System.ComponentModel;

namespace Pustok_Backend.Controllers
{
    public class SubscribeController : Controller
    {
       private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubscribeToNewsletter(SubscribeCreateVM subscribe)
        {
            try
            {


                var existData = await _subscribeService.GetByEmailAsync(subscribe.Email);

                if (existData != null)
                {
                    ModelState.AddModelError("Email", "Email already exist");
                    return RedirectToAction("Index", "Home");

                }

                await _subscribeService.CreateAsync(subscribe);
                return RedirectToAction("Index", "Home");

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
