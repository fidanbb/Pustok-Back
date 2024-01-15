using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pustok_Backend.Areas.Admin.ViewModels.Contact;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                return View(await _contactService.GetAllMessagesAsync());
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
                if (id is null) throw new ArgumentNullException();

                ContactMessageVM dbMessage = await _contactService.GetMessageByIdWithoutTracking((int)id);

                if (dbMessage is null) throw new NullReferenceException();

                await _contactService.DeleteAsync(id);
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
        public async Task<IActionResult> Detail(int? id)
        {
            try
            {
                if (id is null) throw new ArgumentNullException();

                ContactMessageVM dbMessage = await _contactService.GetMessageByIdWithoutTracking((int)id);

                if (dbMessage is null) throw new NullReferenceException();

                return View(dbMessage);
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
