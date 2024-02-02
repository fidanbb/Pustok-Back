using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pustok_Backend.Areas.Admin.ViewModels.Author;
using Pustok_Backend.Areas.Admin.ViewModels.Setting;
using Pustok_Backend.Helpers;
using Pustok_Backend.Helpers.Extensions;
using Pustok_Backend.Models;
using Pustok_Backend.Services;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class SettingController : Controller
    {

        private readonly ISettingService _settingService;
        public SettingController(ISettingService settingService)
        {
            _settingService = settingService;
        }
        [HttpGet]
        public async Task<IActionResult> Index(int page = 1, int take = 5)
        {

            try
            {
                List<Setting> dbPaginatedDatas = await _settingService.GetPaginatedDatasAsync(page, take);

                int pageCount = await GetPageCountAsync(take);
                Paginate<Setting> paginatedDatas = new(dbPaginatedDatas, page, pageCount);
                return View(paginatedDatas);

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

        public async Task<int> GetPageCountAsync(int take)
        {
            int count = await _settingService.GetCountAsync();

            return (int)Math.Ceiling((decimal)(count) / take);
        }

        [HttpGet]

        public async Task<IActionResult> Detail(int? id)
        {
            try
            {
               if(id is null) throw  new ArgumentNullException();

                Setting dbSetting = await _settingService.GetByIdAsync((int)id);
                if(dbSetting is null) return NotFound();

                return View(dbSetting);

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

                Setting dbSetting = await _settingService.GetByIdAsync((int)id);
                if (dbSetting is null) return NotFound();

                SettingEditVM model = new()
                {
                    Key = dbSetting.Key,
                    Value = dbSetting.Value
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
        public async Task<IActionResult> Edit(int? id, SettingEditVM request)
        {
            try
            {
                if (id is null) throw new ArgumentNullException();

                Setting dbSetting = await _settingService.GetByIdAsync((int)id);
                if (dbSetting is null) return NotFound();

                if (dbSetting.Value.Contains("png") || dbSetting.Value.Contains("jpeg") || dbSetting.Value.Contains("jpg")|| dbSetting.Value.Contains("webp"))
                {

                    request.Value = dbSetting.Value;
                    request.Key = dbSetting.Key;


                    if (request.Photo is null)
                    {
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

                }
                else
                {
                    if (id is null) throw new ArgumentNullException();

                    Setting dbsetting = await _settingService.GetByIdAsync((int)id);

                    if (dbSetting is null) throw new NullReferenceException();

                    request.Key = dbSetting.Key;


                    if (!ModelState.IsValid)
                    {
                        return View(request);
                    }

                }


                await _settingService.EditAsync(request);

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
