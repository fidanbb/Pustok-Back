using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pustok_Backend.Areas.Admin.ViewModels.Brand;
using Pustok_Backend.Data;
using Pustok_Backend.Helpers.Extensions;
using Pustok_Backend.Models;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Services
{
    public class BrandService : IBrandService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;

        public BrandService(AppDbContext context,
                              IMapper mapper,
                              IWebHostEnvironment env)
        {
            _context = context;
            _mapper = mapper;
            _env = env;
        }


        public async Task CreateAsync(BrandCreateVM brand)
        {
            foreach (var photo in brand.Photos)
            {
                string fileName = $"{Guid.NewGuid()} - {photo.FileName}";
                string path = _env.GetFilePath("assets/images", fileName);

                await _context.Brands.AddAsync(new Brand { Image = fileName });
                await _context.SaveChangesAsync();

                await photo.SaveFileAsync(path);
            }
        }

        public async Task DeleteAsync(int? id)
        {

            if( id is null) throw new ArgumentNullException();

            Brand dbBrand = await _context.Brands.FirstOrDefaultAsync(m => m.Id == id);

            if (dbBrand is null) throw new NullReferenceException();

            _context.Brands.Remove(dbBrand);
            await _context.SaveChangesAsync();

            string path = _env.GetFilePath("assets/images", dbBrand.Image);
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public async Task EditAsync(BrandEditVM brand)
        {
            string oldPath = _env.GetFilePath("assets/images", brand.Image);

            string fileName = $"{Guid.NewGuid()}-{brand.Photo.FileName}";

            string newPath = _env.GetFilePath("assets/images", fileName);

            Brand dbBrand = await _context.Brands.FirstOrDefaultAsync(m => m.Id == brand.Id);

            dbBrand.Image = fileName;
            dbBrand.UpdatedDate= DateTime.Now;

            await _context.SaveChangesAsync();

            if (File.Exists(oldPath))
            {
                File.Delete(oldPath);
            }

            await brand.Photo.SaveFileAsync(newPath);
        }
        public async Task<ICollection<BrandVM>> GetAllAsync() => _mapper.Map<ICollection<BrandVM>>(await _context.Brands.ToListAsync());

        public async Task<BrandVM> GetByIdAsync(int id)
        {
            return _mapper.Map<BrandVM>(await _context.Brands.FirstOrDefaultAsync(m => m.Id == id));
        }
    }
}
