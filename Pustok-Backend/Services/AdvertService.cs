using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pustok_Backend.Areas.Admin.ViewModels.Advert;
using Pustok_Backend.Data;
using Pustok_Backend.Helpers.Extensions;
using Pustok_Backend.Models;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Services
{
    public class AdvertService : IAdvertService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;


        public AdvertService(AppDbContext context,
                            IMapper mapper,
                            IWebHostEnvironment env)
        {
            _context = context;
            _mapper = mapper;
            _env = env;
        }

        public async Task EditAsync(AdvertEditVM advert)
        {

            string fileName;

            if (advert.Photo is not null)
            {
                string oldPath = _env.GetFilePath("assets/images", advert.Image);
                fileName = $"{Guid.NewGuid()}-{advert.Photo.FileName}";
                string newPath = _env.GetFilePath("assets/images", fileName);
                if (File.Exists(oldPath))
                {
                    File.Delete(oldPath);
                }

                await advert.Photo.SaveFileAsync(newPath);

            }
            else
            {
                fileName = advert.Image;
            }



            Advert dbAdvert = await _context.Adverts.AsNoTracking().FirstOrDefaultAsync(m => m.Id == advert.Id);


            _mapper.Map(advert, dbAdvert);

            dbAdvert.Image = fileName;
            dbAdvert.UpdatedDate = DateTime.Now;


            _context.Adverts.Update(dbAdvert);

            await _context.SaveChangesAsync();
        }

        public async Task<List<AdvertVM>> GetAllAsync() => _mapper.Map<List<AdvertVM>>(await _context.Adverts.ToListAsync());

        public async Task<AdvertVM> GetByIdWithoutTracking(int id)
        {
            return _mapper.Map<AdvertVM>(await _context.Adverts.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id));
        }
    }
}
