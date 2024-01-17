using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pustok_Backend.Areas.Admin.ViewModels.Tag;
using Pustok_Backend.Helpers;
using Pustok_Backend.Services;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class TagController : Controller
    {
        private readonly ITagService _tagService;

        public TagController(ITagService tagService)
        {
            _tagService = tagService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int page=1,int take=5)
        {
            try
            {
                List<TagVM> dbPaginatedDatas=await _tagService.GetPaginatedDatas(page, take);

                int pageCount =await GetPageCountAsync(take);
                Paginate<TagVM> paginatedDatas = new(dbPaginatedDatas, page, pageCount);
                return View(paginatedDatas);
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

        public async Task<int> GetPageCountAsync(int take)
        {
            int tagCount = await _tagService.GetCountAsync();

            return (int)Math.Ceiling((decimal)(tagCount) / take);
        }

        [HttpGet]

        public async Task<IActionResult> Detail(int? id)
        {
            try
            {
                if (id == null) throw new ArgumentNullException();

                TagVM dbTag = await _tagService.GetByIdWithoutTrackingAsync((int)id);

                if (dbTag is null) throw new NullReferenceException();

                return View(dbTag); 
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
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(TagCreateVM request)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    return View();
                }

                TagVM existTag = await _tagService.GetByNameWithoutTrackingAsync(request.Name);

                if (existTag != null)
                {
                    ModelState.AddModelError("Name", "This Tag already exists");
                    return View();
                }


                await _tagService.CreateAsync(request);

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

        [HttpPost]

        public async Task<IActionResult> Delete(int? id)
        {
            try
            {
                if (id is null) throw new ArgumentNullException();

                TagVM tag = await _tagService.GetByIdWithoutTrackingAsync((int)id);

                if(tag is null) throw new NullReferenceException();
                await _tagService.DeleteAsync((int)id);
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
                if (id is null) throw new ArgumentNullException();

                TagVM dbTag = await _tagService.GetByIdWithoutTrackingAsync((int)id);

                if (dbTag is null) throw new NullReferenceException();

                return View(new TagEditVM
                {
                    Name = dbTag.Name
                });
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

        public async Task<IActionResult> Edit(int? id, TagEditVM request)
        {
            try
            {
                if (id is null) throw new ArgumentNullException();

                TagVM dbTag = await _tagService.GetByIdWithoutTrackingAsync((int)id);

                if (dbTag is null) throw new NullReferenceException();


                if (!ModelState.IsValid)
                {
                    return View();
                }

                TagVM existTag = await _tagService.GetByNameWithoutTrackingAsync(request.Name);



                if (existTag != null)
                {
                    if (existTag.Id == request.Id)
                    {
                        await _tagService.EditAsync(request);

                        return RedirectToAction(nameof(Index));
                    }

                    ModelState.AddModelError("Name", "This Tag already exists");
                    return View();
                }

                await _tagService.EditAsync(request);

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
