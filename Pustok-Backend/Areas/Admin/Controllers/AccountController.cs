using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pustok_Backend.Areas.Admin.ViewModels.Account;
using Pustok_Backend.Areas.Admin.ViewModels.Author;
using Pustok_Backend.Helpers;
using Pustok_Backend.Models;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<AppUser> userManager,
                                 RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;

        }
        [HttpGet]
        public async Task<IActionResult> Index(int page = 1, int take = 5)
        {
            try
            {
                var dbUsers = await _userManager.Users.Skip((page * take) - take).Take(take).ToListAsync();

                int pageCount = await GetPageCountAsync(take);

                List<UserVM> users = new();
                foreach (var user in dbUsers)
                {
                    var roles = await _userManager.GetRolesAsync(user);
                    users.Add(new UserVM
                    {
                        Id = user.Id,
                        Name = user.Name,
                        Surname = user.Surname,
                        Email = user.Email,
                        Username = user.UserName,
                        RoleNames = roles
                    });
                }

                Paginate<UserVM> paginatedDatas = new(users, page, pageCount);


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
            int count = await _userManager.Users.CountAsync();

            return (int)Math.Ceiling((decimal)(count) / take);
        }

        [HttpGet]
        public async Task<IActionResult> AddRoleToUser()
        {
            ViewBag.roles = await GetRolesAsync();
            ViewBag.users = await GetUsersAsync();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddRoleToUser(UserRoleVM request)
        {
            AppUser user = await _userManager.FindByIdAsync(request.UserId);

            IdentityRole role = await _roleManager.FindByIdAsync(request.RoleId);

            await _userManager.AddToRoleAsync(user, role.Name);

            return RedirectToAction("Index", "Account");
        }


        private async Task<SelectList> GetRolesAsync()
        {
            return new SelectList(await _roleManager.Roles.ToListAsync(), "Id", "Name");
        }

        private async Task<SelectList> GetUsersAsync()
        {
            return new SelectList(await _userManager.Users.ToListAsync(), "Id", "UserName");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(string id)
        {
            try
            {
                if (id is null) throw new ArgumentNullException();

                AppUser user = await _userManager.FindByIdAsync(id);

                if (user is null) throw new NullReferenceException();

               var result= await _userManager.DeleteAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(Index));
                }

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
        public async Task<IActionResult> RemoveRoleFromUser()
        {
            ViewBag.roles = await GetRolesAsync();
            ViewBag.users = await GetUsersAsync();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveRoleFromUser(UserRoleVM request)
        {
            AppUser user = await _userManager.FindByIdAsync(request.UserId);
            IdentityRole role = await _roleManager.FindByIdAsync(request.RoleId);

            if(role.Name.Trim().ToLower() == "SuperAdmin".Trim().ToLower())
            {
                ModelState.AddModelError("RoleId", "You can not delete this role from user");
                ViewBag.roles = await GetRolesAsync();
                ViewBag.users = await GetUsersAsync();
                return View(request);
            }

            await _userManager.RemoveFromRoleAsync(user, role.Name);
            return RedirectToAction(nameof(Index));
        }
    }
}
