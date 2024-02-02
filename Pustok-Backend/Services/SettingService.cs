using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pustok_Backend.Areas.Admin.ViewModels.Setting;
using Pustok_Backend.Data;
using Pustok_Backend.Helpers.Extensions;
using Pustok_Backend.Models;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Services
{
    public class SettingService:ISettingService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;

        public SettingService(AppDbContext context,
                              IWebHostEnvironment env,
                              IMapper mapper)
        {
            _context = context;
            _env = env;
            _mapper = mapper;
        }

        public Dictionary<string, string> GetSettings()
        {
            return _context.Settings.Where(m => !m.SoftDeleted)
                                    .AsEnumerable()
                                    .ToDictionary(m => m.Key, m => m.Value);
        }
        public async Task<List<Setting>> GetAllAsync()
        {
            return await _context.Settings.ToListAsync();
        }

        public async Task<Setting> GetByIdAsync(int id)
        {
            return await _context.Settings.FirstOrDefaultAsync(m => m.Id == id);
        }



        public async Task EditAsync(SettingEditVM setting)
        {
            if (setting.Value.Contains("jpg") || setting.Value.Contains("png") || setting.Value.Contains("jpeg") || setting.Value.Contains("webp"))
            {
                string oldPath = _env.GetFilePath("assets/images", setting.Value);

                string fileName = $"{Guid.NewGuid()}-{setting.Photo.FileName}";

                string newPath = _env.GetFilePath("assets/images", fileName);

                Setting dbSetting = await _context.Settings.FirstOrDefaultAsync(m => m.Id == setting.Id);

                dbSetting.Value = fileName;
                dbSetting.UpdatedDate = DateTime.Now;

                await _context.SaveChangesAsync();

                if (File.Exists(oldPath))
                {
                    File.Delete(oldPath);
                }

                await setting.Photo.SaveFileAsync(newPath);
            }
            else
            {
                Setting dbSetting = await _context.Settings.FirstOrDefaultAsync(m => m.Id == setting.Id);

                _mapper.Map(setting, dbSetting);

                dbSetting.UpdatedDate = DateTime.Now;

                _context.Settings.Update(dbSetting);

                await _context.SaveChangesAsync();
            }

        }

        public async Task<int> GetCountAsync()
        {
           return await _context.Settings.CountAsync();
        }

        public async Task<List<Setting>> GetPaginatedDatasAsync(int page, int take)
        {
            return await _context.Settings.Skip((page*take)-take).Take(take).ToListAsync();
        }
    }
}
