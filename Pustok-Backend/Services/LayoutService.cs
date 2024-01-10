using Pustok_Backend.Services.Interfaces;
using Pustok_Backend.ViewModels.Layout;

namespace Pustok_Backend.Services
{
    public class LayoutService : ILayoutService
    {
        private readonly ISettingService _settingService;

        public LayoutService( ISettingService settingService)
        {
           
            _settingService = settingService;
        }
        public FooterVM GetFooterDatas()
        {
            Dictionary<string, string> settingDatas = _settingService.GetSettings();
            return new FooterVM
            {
                FooterLogo = settingDatas["FooterLogo"],
                Address = settingDatas["Address"],
                Phone = settingDatas["Phone"],
                Email = settingDatas["Email"],
                PaymentMethod = settingDatas["PaymentMethod"]
            };
        }

        public HeaderVM GetHeaderDatas()
        {
            Dictionary<string, string> settingDatas = _settingService.GetSettings();
            return new HeaderVM
            {
                HeaderLogo = settingDatas["HeaderLogo"],
                Phone = settingDatas["Phone"],
                Email = settingDatas["Email"]
                
            };
        }
    }
}
