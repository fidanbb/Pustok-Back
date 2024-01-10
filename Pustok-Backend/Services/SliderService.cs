using AutoMapper;
using Microsoft.EntityFrameworkCore; 
using Pustok_Backend.Areas.Admin.ViewModels.Advert;
using Pustok_Backend.Areas.Admin.ViewModels.Slider;
using Pustok_Backend.Data;
using Pustok_Backend.Helpers.Extensions;
using Pustok_Backend.Models;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Services
{
    public class SliderService : ISliderService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;


        public SliderService(AppDbContext context,
                            IMapper mapper,
                            IWebHostEnvironment env)
        {
            _context = context;
            _mapper = mapper;
            _env = env;
        }

        public async Task CreateAsync(SliderCreateVM slider)
        {
            string fileName = $"{Guid.NewGuid()}-{slider.Photo.FileName}";

            string path = _env.GetFilePath("assets/images", fileName);

            var data = _mapper.Map<Slider>(slider);

            data.Image = fileName;

            await _context.Sliders.AddAsync(data);
            await _context.SaveChangesAsync();

            await slider.Photo.SaveFileAsync(path);
        }

        public async Task DeleteAsync(int? id)
        {
            
                if (id is null) throw new ArgumentNullException();

                Slider dbSlider = await _context.Sliders.Where(m => m.Id == id).FirstOrDefaultAsync();

                if (dbSlider is null) throw new NullReferenceException();

                _context.Sliders.Remove(dbSlider);
                await _context.SaveChangesAsync();

                string path = _env.GetFilePath("assets/images", dbSlider.Image); ;

                if (File.Exists(path))
                {
                    File.Delete(path);
                } 
          
        }
         
        public async Task EditAsync(SliderEditVM slider)
        {
            string fileName;

            if (slider.Photo is not null)
            {
                string oldPath = _env.GetFilePath("assets/images", slider.Image);
                fileName = $"{Guid.NewGuid()}-{slider.Photo.FileName}";
                string newPath = _env.GetFilePath("assets/images", fileName);
                if (File.Exists(oldPath))
                {
                    File.Delete(oldPath);
                }

                await slider.Photo.SaveFileAsync(newPath);

            }
            else
            {
                fileName = slider.Image;
            }



            Slider dbSlider = await _context.Sliders.AsNoTracking().FirstOrDefaultAsync(m => m.Id == slider.Id);


            _mapper.Map(slider, dbSlider);

            dbSlider.Image = fileName;


            _context.Sliders.Update(dbSlider);

            await _context.SaveChangesAsync();
        }

        public async Task<List<SliderVM>> GetAllAsync()
        {
            return _mapper.Map<List<SliderVM>>( await _context.Sliders.Include(m=>m.Direction).ToListAsync());
        }

        public async Task<SliderVM> GetByIdWithoutTrackingAsync(int id)
        {
            return _mapper.Map<SliderVM>(await _context.Sliders.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id));
        }
    }
}
