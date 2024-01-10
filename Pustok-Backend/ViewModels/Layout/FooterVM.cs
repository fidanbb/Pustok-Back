using Pustok_Backend.Areas.Admin.ViewModels.Social;
using Pustok_Backend.Areas.Admin.ViewModels.Subscribe;

namespace Pustok_Backend.ViewModels.Layout
{
    public class FooterVM
    {
        public string FooterLogo { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PaymentMethod { get; set; }
        public List<SocialVM> Socials { get; set; }

        public SubscribeVM Subscribe { get; set; }

    }
}
