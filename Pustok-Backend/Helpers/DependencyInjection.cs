﻿using Pustok_Backend.Services;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Helpers
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServiceLayer(this IServiceCollection services)
        {
            services.AddScoped<ISliderService, SliderService>();
            services.AddScoped<ISiteServicesService, SiteServicesService>();
            services.AddScoped<IAdvertService, AdvertService>();
            services.AddScoped<IBrandService, BrandService>();
            services.AddScoped<IDirectionService, DirectionService>();
            services.AddScoped<ISettingService, SettingService>();
            services.AddScoped<ILayoutService, LayoutService>();







            return services;
        }
    }
}