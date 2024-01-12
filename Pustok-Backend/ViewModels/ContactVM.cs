using Pustok_Backend.Areas.Admin.ViewModels.Brand;
using Pustok_Backend.Areas.Admin.ViewModels.Contact;
using Pustok_Backend.Areas.Admin.ViewModels.Social;

namespace Pustok_Backend.ViewModels
{
    public class ContactVM
    {
        public ICollection<BrandVM> Brands { get; set; }
        public List<SocialVM> Socials { get; set; }

        public Dictionary<string,string> Settings { get; set; }

        public ContactMessageCreateVM MessageCreate { get; set; }
    }
}
