using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pustok_Backend.Models;

namespace Pustok_Backend.Data
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Direction> Directions { get; set; }

        public DbSet<Service> Services { get; set; }
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<Brand> Brands { get; set; }

        public DbSet<Setting>Settings { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Slider>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Service>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Advert>().HasQueryFilter(m => !m.SoftDeleted);

            modelBuilder.Entity<Brand>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Setting>().HasQueryFilter(m => !m.SoftDeleted);



            modelBuilder.Entity<Slider>().HasData(
          new Slider { Id = 1, Image = "home-slider-1-ai.webp", Header = "J.D. Kurtness", Title = "De Vengeance", Description = " Cover Up Front Of Books and Leave Summary",DirectionId=1, SoftDeleted = false },
          new Slider { Id = 2, Image = "home-slider-2-ai.webp", Header = "H.G. Wells", Title = "De Vengeance", Description = "Cover Up Front Of Books and Leave Summary",DirectionId=2, SoftDeleted = false }

      );

            modelBuilder.Entity<Direction>().HasData(
                new Direction { Id = 1, Name = "right" },
                new Direction { Id = 2, Name = "left" }
                );

            modelBuilder.Entity<Service>().HasData(

                new Service { Id=1,Title= "Free Shipping Item", Description= "Orders over $500", IconName= "fas fa-shipping-fast" },
               new Service { Id = 2, Title = "Money Back Guarantee", Description = "100% money back", IconName = "fas fa-redo-alt" }, 
               new Service { Id = 3, Title = "Cash On Delivery", Description = "Lorem ipsum dolor amet", IconName = "fas fa-piggy-bank" },

                     new Service { Id = 4, Title = "Help & Support", Description = "Call us : + 0123.4567.89", IconName = "fas fa-life-ring" }

                );

            modelBuilder.Entity<Advert>().HasData(
                new Advert { Id=1,Image= "promo-banner-with-text.webp" },
                new Advert { Id =2, Image = "promo-banner-with-text-2.webp" },
                new Advert { Id = 3, Image = "promo-banner-mid.webp", Header= "Buy 3. Get Free 1.", Title= "50% off for selected products in Pustok." },
                new Advert { Id = 4, Image = "promo-banner-small.webp", Header = "$26.00", Title = "Praise for The Night Child" },
                new Advert { Id = 5, Image = "promo-banner-full.webp", Header = "I Love This Idea!", Title = "Cover up front of book and leave summary" }
                );

            modelBuilder.Entity<Brand>().HasData(
                new Brand { Id=1,Image= "brand-1.webp" },
                new Brand { Id = 2, Image = "brand-2.webp" },
                new Brand { Id = 3, Image = "brand-3.webp" },
                new Brand { Id = 4, Image = "brand-4.webp" },
                new Brand { Id = 5, Image = "brand-5.webp" },
                new Brand { Id = 6, Image = "brand-6.webp" }
                );

            modelBuilder.Entity<Setting>().HasData(
                new Setting { Id=1,Key="HeaderLogo",Value= "logo.webp" },
                new Setting { Id=2,Key="FooterLogo",Value= "logo--footer.webp" },
                new Setting { Id = 3, Key = "Address", Value = "Example Street 98, HH2 BacHa, New York, USA" },
                new Setting { Id = 4, Key = "Phone", Value = "+18088 234 5678" },
                new Setting { Id = 5, Key = "Email", Value = "support@hastech.com" },
                new Setting { Id = 6, Key = "PaymentMethod", Value = "payment.webp" }
                );

        }

    }
}
