using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pustok_Backend.Areas.Admin.ViewModels.Author;
using Pustok_Backend.Areas.Admin.ViewModels.Category;
using Pustok_Backend.Data;
using Pustok_Backend.Helpers.Extensions;
using Pustok_Backend.Models;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;


        public CategoryService(AppDbContext context,
                               IMapper mapper,
                               IWebHostEnvironment env)
        {
            _context = context;
            _mapper = mapper;
            _env = env;

        }
        public async Task<List<CategoryVM>> GetAllAsync()
        {
            return _mapper.Map<List<CategoryVM>>(await _context.Categories.Include(m=>m.Products).ToListAsync());
        }

        public async Task CreateAsync(CategoryCreateVM category)
        {
            Category dbCategory = _mapper.Map<Category>(category);

            await _context.Categories.AddAsync(dbCategory);
            await _context.SaveChangesAsync();
        }


        public async Task DeleteAsync(int id)
        {
            Category dbCategory = await _context.Categories.Where(m => m.Id == id).Include(m => m.Products).ThenInclude(m => m.Images).FirstOrDefaultAsync();
            _context.Categories.Remove(dbCategory);
            await _context.SaveChangesAsync();

            foreach (var product in dbCategory.Products)
            {
                foreach (var productImage in product.Images)
                {
                    string path = _env.GetFilePath("assets/images", productImage.Image);
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                }
            }
        }

        public async Task EditAsync(CategoryEditVM category)
        {
            Category dbCategory = await _context.Categories.AsNoTracking().FirstOrDefaultAsync(m => m.Id == category.Id);

            _mapper.Map(category, dbCategory);
            dbCategory.UpdatedDate = DateTime.Now;

            _context.Categories.Update(dbCategory);

            await _context.SaveChangesAsync();
        }

        public async Task<CategoryVM> GetByIdWithoutTrackingAsync(int id)
        {
            return _mapper.Map<CategoryVM>(await _context.Categories.Include(m => m.Products).AsNoTracking()
                                                                      .FirstOrDefaultAsync(m => m.Id == id));
        }

        public async Task<CategoryVM> GetByNameWithoutTrackingAsync(string name)
        {
            return _mapper.Map<CategoryVM>(await _context.Categories.AsNoTracking()
                                                         .FirstOrDefaultAsync(m => m.Name.Trim().ToLower() == name.Trim().ToLower()));
        }
        public Task<int> GetCountAsync()
        {
            return _context.Categories.CountAsync();
        }

        public async Task<List<CategoryVM>> GetPaginatedDatasAsync(int page, int take)
        {
            return _mapper.Map<List<CategoryVM>>(await _context.Categories.Include(m => m.Products)
                                                                             .Skip((page * take) - take)
                                                                             .Take(take)
                                                                             .ToListAsync());

        }


    }
}
