using AutoMapper;
using Pustok_Backend.Areas.Admin.ViewModels.Advert;
using Pustok_Backend.Areas.Admin.ViewModels.Brand;
using Pustok_Backend.Areas.Admin.ViewModels.Service;
using Pustok_Backend.Areas.Admin.ViewModels.Slider;
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





        }
    }
}
