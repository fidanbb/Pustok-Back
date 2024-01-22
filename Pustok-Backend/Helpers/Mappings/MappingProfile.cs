using AutoMapper;
using Pustok_Backend.Areas.Admin.ViewModels.Advert;
using Pustok_Backend.Areas.Admin.ViewModels.Author;
using Pustok_Backend.Areas.Admin.ViewModels.Blog;
using Pustok_Backend.Areas.Admin.ViewModels.BlogAuthor;
using Pustok_Backend.Areas.Admin.ViewModels.BlogComment;
using Pustok_Backend.Areas.Admin.ViewModels.Brand;
using Pustok_Backend.Areas.Admin.ViewModels.Category;
using Pustok_Backend.Areas.Admin.ViewModels.Contact;
using Pustok_Backend.Areas.Admin.ViewModels.Product;
using Pustok_Backend.Areas.Admin.ViewModels.ProductComment;
using Pustok_Backend.Areas.Admin.ViewModels.Service;
using Pustok_Backend.Areas.Admin.ViewModels.Setting;
using Pustok_Backend.Areas.Admin.ViewModels.Slider;
using Pustok_Backend.Areas.Admin.ViewModels.Social;
using Pustok_Backend.Areas.Admin.ViewModels.Subscribe;
using Pustok_Backend.Areas.Admin.ViewModels.Tag;
using Pustok_Backend.Areas.Admin.ViewModels.Testimonial;
using Pustok_Backend.Models;

namespace Pustok_Backend.Helpers.Mappings
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Slider, SliderVM>().ForMember(dest => dest.Direction, opt => opt.MapFrom(src => src.Direction.Name));

            CreateMap<Service, ServiceVM>();
            CreateMap<Advert, AdvertVM>();
            CreateMap<Brand, BrandVM>();

            CreateMap<SliderCreateVM, Slider>();
            CreateMap<SliderVM, SliderEditVM>();

            CreateMap<SliderEditVM, Slider>();

            CreateMap<BrandCreateVM, Brand>();

            CreateMap<BrandEditVM, Brand>();
            CreateMap<ServiceVM, ServiceEditVM>();

            CreateMap<ServiceEditVM, Service>();

            CreateMap<AdvertVM, AdvertEditVM>();

            CreateMap<AdvertEditVM, Advert>();

            CreateMap<Social, SocialVM>();
            CreateMap<SocialVM, SocialEditVM>();

            CreateMap<SocialEditVM, Social>();

            CreateMap<Setting, SettingEditVM>();
            CreateMap<SettingEditVM, Setting>();
            CreateMap<Subscribe, SubscribeVM>();
            CreateMap<SubscribeCreateVM, Subscribe>();
            CreateMap<SubscribeCreateVM, SubscribeVM>();
            CreateMap<ContactMessage, ContactMessageVM>();
            CreateMap<ContactMessageCreateVM, ContactMessage>();

            CreateMap<Testimonial, TestimonialVM>().ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.AppUser.Name))
                                                   .ForMember(dest => dest.Surname, opt => opt.MapFrom(src => src.AppUser.Surname))
                                                   .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.AppUser.Image));


            CreateMap<Blog, BlogVM>().ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.BlogAuthor.FullName))
                                     .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Images.FirstOrDefault(m=>m.IsMain).Image));
            CreateMap<Tag, TagVM>();

            CreateMap<Blog, BlogDetailVM>().ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.BlogAuthor.FullName))
                                   .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Images.FirstOrDefault(m => m.IsMain).Image))
                                    .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.BlogTags.Select(m => m.Tag).ToList()))
                                    .ForMember(dest => dest.Comments, opt => opt.MapFrom(src => src.BlogComments));

            CreateMap<BlogComment, BlogCommentVM>().ForMember(dest => dest.BlogTitle, opt => opt.MapFrom(src => src.Blog.Title))
                                                   .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.AppUser.Name))
                                                   .ForMember(dest => dest.Surname, opt => opt.MapFrom(src => src.AppUser.Surname));

            CreateMap<BlogCommentCreateVM, BlogComment>();
            CreateMap<TagCreateVM, Tag>();
            CreateMap<TagEditVM, Tag>();

            CreateMap<BlogAuthor, BlogAuthorVM>()
     .ForMember(dest => dest.BlogTitles, opt => opt.MapFrom(src => src.Blogs.Select(blog => blog.Title).ToList()));

            CreateMap<BlogAuthorCreateVM, BlogAuthor>();
            CreateMap<BlogAuthorEditVM, BlogAuthor>();

            CreateMap<Blog, BlogCreateVM>().ReverseMap();
            CreateMap<BlogEditVM, Blog>();
            CreateMap<Category, CategoryVM>();
            CreateMap<Product, ProductVM>().ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.Author.FullName))
                                           .ForMember(dest => dest.Discount, opt => opt.MapFrom(src => src.Discount.Percent));

            CreateMap<Product, ProductDetailVM>().ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.Author.FullName))
                                       .ForMember(dest => dest.Discount, opt => opt.MapFrom(src => src.Discount.Percent))
                                       .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
                                        .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.ProductTags.Select(m => m.Tag).ToList()));


            CreateMap<ProductComment, ProductCommentVM>().ForMember(dest => dest.ProductTitle, opt => opt.MapFrom(src => src.Product.Name))
                                       .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.AppUser.Name))
                                       .ForMember(dest => dest.Surname, opt => opt.MapFrom(src => src.AppUser.Surname));

            CreateMap<ProductCommentCreateVM, ProductComment>();

            CreateMap<Author, AuthorVM>()
                     .ForMember(dest => dest.ProductTitles, opt => opt.MapFrom(src => src.Products.Select(product => product.Name).ToList()));
            CreateMap<AuthorCreateVM, Author>();
            CreateMap<AuthorEditVM,Author>();
        }
    }
}
