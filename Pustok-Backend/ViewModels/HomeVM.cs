using Pustok_Backend.Areas.Admin.ViewModels.Advert;
using Pustok_Backend.Areas.Admin.ViewModels.Blog;
using Pustok_Backend.Areas.Admin.ViewModels.Brand;
using Pustok_Backend.Areas.Admin.ViewModels.Service;
using Pustok_Backend.Areas.Admin.ViewModels.Slider;
using Pustok_Backend.Areas.Admin.ViewModels.Testimonial;

namespace Pustok_Backend.ViewModels
{
    public class HomeVM
    {
        public List<SliderVM> Sliders { get; set; }
        public ICollection<ServiceVM> SiteServices { get; set; }
        public List<AdvertVM > Adverts { get; set; }
        public ICollection<BrandVM> Brands { get; set; }

        public List<TestimonialVM> Testimonials { get; set; }

        public List<BlogVM> Blogs { get; set; }

    }
}
