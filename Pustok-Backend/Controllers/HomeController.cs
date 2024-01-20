using Microsoft.AspNetCore.Mvc;
using Pustok_Backend.Areas.Admin.ViewModels.Advert;
using Pustok_Backend.Areas.Admin.ViewModels.Blog;
using Pustok_Backend.Areas.Admin.ViewModels.Brand;
using Pustok_Backend.Areas.Admin.ViewModels.Product;
using Pustok_Backend.Areas.Admin.ViewModels.Service;
using Pustok_Backend.Areas.Admin.ViewModels.Slider;
using Pustok_Backend.Areas.Admin.ViewModels.Testimonial;
using Pustok_Backend.Services.Interfaces;
using Pustok_Backend.ViewModels;
using System.Diagnostics;

namespace Pustok_Backend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly ISiteServicesService _siteServicesService;
        private readonly IAdvertService _advertService;
        private readonly IBrandService _brandService;
        private readonly ITestimonialService _testimonialService;
        public readonly IBlogService _blogService;
        private readonly IProductService _productService;

        public HomeController(ISliderService sliderService,
                               ISiteServicesService siteServicesService,
                               IAdvertService advertService,
                               IBrandService brandService,
                               ITestimonialService testimonialService,
                               IBlogService blogService,
                               IProductService productService)
        {
                _sliderService = sliderService;
            _siteServicesService = siteServicesService;
            _advertService = advertService;
            _brandService = brandService;
            _testimonialService = testimonialService;
            _blogService = blogService;
            _productService = productService;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                List<SliderVM> sliders = await _sliderService.GetAllAsync();
                ICollection<ServiceVM> siteServices = await _siteServicesService.GetAllAsync();
                List<AdvertVM> adverts = await _advertService.GetAllAsync();
                ICollection <BrandVM> brands =await _brandService.GetAllAsync();
                List<TestimonialVM> testimonials = await _testimonialService.GetWithIncludesAndTakeAsync(4);
                List<BlogVM> blogs= await _blogService.GetAllWithTakeInDescendingOrderAsync(3);
                List<ProductVM> featuredProducts=await _productService.GetFeaturedProductsWithTakeAsync(6);
                List<ProductVM> newArrivedProducts = await _productService.GetNewArrivedProductsWithTakeAsync(6);
                List<ProductVM> mostViewedProducts = await _productService.GetMostViewedProductsWithTakeAsync(6);
                List<ProductVM> dealOfTheDay = await _productService.GetDealOfTheDayProductsWithTakeAsync(6);
                List<ProductVM> bestSellers = await _productService.GetBestSellerProductsAsync();
                List<ProductVM> childrensBooks = await _productService.GetProductsByCategoryWithTakeAsync(6, "Children's Books");
                List<ProductVM> artBooks = await _productService.GetProductsByCategoryWithTakeAsync(6, "Arts & Photography");


                HomeVM model = new()
                {
                    Sliders = sliders,
                    SiteServices = siteServices,
                    Adverts = adverts,
                    Brands = brands,
                    Testimonials = testimonials,
                    Blogs = blogs,
                    FeaturedProducts = featuredProducts,
                    NewArrivedProducts= newArrivedProducts,
                    MostViewedProducts= mostViewedProducts,
                    DealOfTheDay = dealOfTheDay,
                    BestSellers = bestSellers,
                    ChildrensBooks = childrensBooks,
                    ArtPhorographyBooks = artBooks,
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
    }
}
