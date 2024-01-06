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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Slider>().HasQueryFilter(m => !m.SoftDeleted);



            modelBuilder.Entity<Slider>().HasData(
          new Slider { Id = 1, Image = "home-slider-1-ai.webp", Header = "J.D. Kurtness", Title = "De Vengeance", Description = " Cover Up Front Of Books and Leave Summary",DirectionId=1, SoftDeleted = false },
          new Slider { Id = 2, Image = "home-slider-2-ai.webp", Header = "H.G. Wells", Title = "De Vengeance", Description = "Cover Up Front Of Books and Leave Summary",DirectionId=2, SoftDeleted = false }

      );

            modelBuilder.Entity<Direction>().HasData(
                new Direction { Id = 1, Name = "right" },
                new Direction { Id = 2, Name = "left" }
                );

        }

    }
}
