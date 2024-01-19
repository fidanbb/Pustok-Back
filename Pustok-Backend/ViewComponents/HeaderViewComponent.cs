using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pustok_Backend.Models;
using Pustok_Backend.Services.Interfaces;
using Pustok_Backend.ViewModels.Layout;
using System.Security.Claims;

namespace Pustok_Backend.ViewComponents
{
    public class HeaderViewComponent: ViewComponent
    {
        private readonly ILayoutService _layoutService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<AppUser> _userManager;

        public HeaderViewComponent(ILayoutService layoutService,
                                    IHttpContextAccessor httpContextAccessor,
                                    UserManager<AppUser> userManager)
        {
            _layoutService = layoutService;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
          
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            HeaderVM model = await _layoutService.GetHeaderDatas();
            

            string userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId is not null)
            {
                AppUser currentUser = await _userManager.FindByIdAsync(userId);
                model.UserFullName = currentUser.Name + " " +currentUser.Surname;
            }
            


            return await Task.FromResult(View(model));
        }
    }
}
