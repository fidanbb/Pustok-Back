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
        public DbSet<Social> Socials { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }

        public DbSet<ContactMessage> ContactMessages { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }






        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Slider>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Service>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Advert>().HasQueryFilter(m => !m.SoftDeleted);

            modelBuilder.Entity<Brand>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Setting>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Social>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Subscribe>().HasQueryFilter(m => !m.SoftDeleted);

            modelBuilder.Entity<ContactMessage>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Testimonial>().HasQueryFilter(m => !m.SoftDeleted);



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
                new Setting { Id = 3, Key = "Address", Value = "7/135 Saint St. London" },
                new Setting { Id = 4, Key = "Phone", Value = "+18088 234 5678" },
                new Setting { Id = 5, Key = "Email", Value = "support@hastech.com" },
                new Setting { Id = 6, Key = "PaymentMethod", Value = "payment.webp" },
                new Setting { Id = 7, Key = "Address2", Value = "1130/5 Louis III St. New York" },
                new Setting { Id = 8, Key = "Phone2", Value = "+18088 625 4251" },
                new Setting { Id = 9, Key = "Email2", Value = "info@lawyersattorneys.com" }
                );

            modelBuilder.Entity<Social>().HasData(
                new Social { Id=1,IconName= "fa-brands fa-facebook-f", Link= "https://www.facebook.com/" },
                new Social { Id = 2, IconName = "fa-brands fa-twitter", Link = "https://twitter.com/" },
                new Social { Id = 3, IconName = "fa-brands fa-google", Link = "https://www.google.com/" },
                new Social { Id = 4, IconName = "fa-brands fa-youtube", Link = "https://www.youtube.com/" }
                );


            modelBuilder.Entity<Subscribe>().HasData(
                new Subscribe { Id = 1,Email="surac@gmail.com"},
                new Subscribe { Id = 2, Email = "kubra@gmail.com" }
                );



            modelBuilder.Entity<ContactMessage>().HasData(
                new ContactMessage { Id = 1, Name = "Fidan Bashirova", Email = "fidanbb@code.edu.az", Message = "Helllooo" }
                );


            modelBuilder.Entity<Testimonial>().HasData(
                
                new Testimonial { Id=1,Review= " Discovered Pustok, a reader's paradise! Vast collection caters to every literary taste. User-friendly interface made browsing a delight. Quick shipping, excellent customer service – my go-to online bookstore.", AppUserId= "0efd01de-4eec-45ff-9de4-f03f9abdf104" },
                new Testimonial { Id = 2, Review = "Explored numerous online bookstores, but this one stands out. Curated selection, easy navigation – a reader's haven. Intuitive layout, discover new titles effortlessly. Timely delivery, well-packaged books – highly recommended satisfaction!.", AppUserId = "122ee49a-1c09-45ba-a6a5-4e94b3be7c85" },
                new Testimonial { Id = 3, Review = "Exceeded expectations, Pustok website. Robust search functionality, find what I wanted easily. Seamless checkout process, orders arrive promptly. Attention to detail, quality service keeps me coming back for more literary treasures.", AppUserId = "4e8b3ae2-4358-4d32-8fdf-d9a95df929e7" },
                new Testimonial { Id = 4, Review = "Can't say enough good things about Pustok! Vast array of genres, inclusion of hard-to-find titles. Aesthetically pleasing and highly functional design. Orders accurate, well-packaged, delivered on time – a gem in online book retail!", AppUserId = "8dce53a3-4394-46c3-8ebd-dbb06801e22e" },
                new Testimonial { Id = 5, Review = " hard-to-find titles. Aesthetically pleasing and highly functional design. Orders accurate, well-packaged, delivered on time – a gem in online book retail!", AppUserId = "8dce53a3-4394-46c3-8ebd-dbb06801e22e" },
                 new Testimonial { Id = 6, Review = "Can't say enough good things aboard-to-find e book retail!", AppUserId = "8dce53a3-4394-46c3-8ebd-dbb06801e22e" }


                );

        }

    }
}
