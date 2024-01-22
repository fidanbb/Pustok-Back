using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pustok_Backend.Areas.Admin.ViewModels.Author;
using Pustok_Backend.Areas.Admin.ViewModels.BlogAuthor;
using Pustok_Backend.Data;
using Pustok_Backend.Helpers.Extensions;
using Pustok_Backend.Models;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;


        private readonly IMapper _mapper;

        public AuthorService(AppDbContext context,
                                 IWebHostEnvironment env,
                                 IMapper mapper)
        {
            _context = context;
            _env = env;
            _mapper = mapper;
        }

        public async Task CreateAsync(AuthorCreateVM author)
        {
            Author dbAuthor = _mapper.Map<Author>(author);

            await _context.Authors.AddAsync(dbAuthor);
            await _context.SaveChangesAsync();
        }


        public async Task DeleteAsync(int id)
        {
            Author dbAuthor = await _context.Authors.Where(m => m.Id == id).Include(m => m.Products).ThenInclude(m => m.Images).FirstOrDefaultAsync();
            _context.Authors.Remove(dbAuthor);
            await _context.SaveChangesAsync();

            foreach (var product in dbAuthor.Products)
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

        public async Task EditAsync(AuthorEditVM author)
        {
            Author dbAuthor = await _context.Authors.AsNoTracking().FirstOrDefaultAsync(m => m.Id == author.Id);

            _mapper.Map(author, dbAuthor);
            dbAuthor.UpdatedDate = DateTime.Now;

            _context.Authors.Update(dbAuthor);

            await _context.SaveChangesAsync();
        }

        public async Task<AuthorVM> GetByIdWithoutTrackingAsync(int id)
        {
            return _mapper.Map<AuthorVM>(await _context.Authors.Include(m => m.Products).AsNoTracking()
                                                                      .FirstOrDefaultAsync(m => m.Id == id));
        }

        public async Task<AuthorVM> GetByNameWithoutTrackingAsync(string name)
        {
            return _mapper.Map<AuthorVM>(await _context.Authors.AsNoTracking()
                                                         .FirstOrDefaultAsync(m => m.FullName.Trim().ToLower() == name.Trim().ToLower()));
        }
        public Task<int> GetCountAsync()
        {
            return _context.Authors.CountAsync();
        }

        public async Task<List<AuthorVM>> GetPaginatedDatasAsync(int page, int take)
        {
            return _mapper.Map<List<AuthorVM>>(await _context.Authors.Include(m => m.Products)
                                                                             .Skip((page * take) - take)
                                                                             .Take(take)
                                                                             .ToListAsync());

        }
    }
}
