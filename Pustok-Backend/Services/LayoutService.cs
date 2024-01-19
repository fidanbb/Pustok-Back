using Pustok_Backend.Services.Interfaces;
using Pustok_Backend.ViewModels.Layout;

namespace Pustok_Backend.Services
{
    public class LayoutService : ILayoutService
    {
        private readonly ISettingService _settingService;
        private readonly ISocialService _socialService;
        private readonly ICategoryService _categoryService;

        public LayoutService( ISettingService settingService,
                              ISocialService socialService,
                              ICategoryService categoryService)
        {
           
            _settingService = settingService;
            _socialService = socialService;
            _categoryService = categoryService;
        }
        public async Task< FooterVM> GetFooterDatas()
        {
            Dictionary<string, string> settingDatas = _settingService.GetSettings();
            return new FooterVM
            {
                FooterLogo = settingDatas["FooterLogo"],
                Address = settingDatas["Address"],
                Phone = settingDatas["Phone"],
                Email = settingDatas["Email"],
                PaymentMethod = settingDatas["PaymentMethod"],
                Socials = await _socialService.GetAllAsync()
            };
        }

        public async Task<HeaderVM> GetHeaderDatas()
        {
            Dictionary<string, string> settingDatas = _settingService.GetSettings();
            return new HeaderVM
            {
                HeaderLogo = settingDatas["HeaderLogo"],
                Phone = settingDatas["Phone"],
                Email = settingDatas["Email"],
                Categories =await _categoryService.GetAllAsync()
                
            };
        }
    }
}
