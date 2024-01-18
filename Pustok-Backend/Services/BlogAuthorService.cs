using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Pustok_Backend.Areas.Admin.ViewModels.Blog;
using Pustok_Backend.Areas.Admin.ViewModels.BlogAuthor;
using Pustok_Backend.Areas.Admin.ViewModels.Tag;
using Pustok_Backend.Data;
using Pustok_Backend.Helpers.Extensions;
using Pustok_Backend.Models;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Services
{
    public class BlogAuthorService : IBlogAuthorService
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;


        private readonly IMapper _mapper;

        public BlogAuthorService(AppDbContext context,
                                 IWebHostEnvironment env,
                                 IMapper mapper)
        {
            _context = context;
            _env = env;
            _mapper = mapper;
        }

        public async Task CreateAsync(BlogAuthorCreateVM blogAuthor)
        {
            BlogAuthor dbBlogAuthor = _mapper.Map<BlogAuthor>(blogAuthor);

            await _context.BlogAuthors.AddAsync(dbBlogAuthor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            BlogAuthor dbBlogAuthor = await _context.BlogAuthors.Where(m => m.Id == id).Include(m => m.Blogs).ThenInclude(m=>m.Images).FirstOrDefaultAsync();
            _context.BlogAuthors.Remove(dbBlogAuthor);
            await _context.SaveChangesAsync();

            foreach (var blog in dbBlogAuthor.Blogs)
            {
                foreach (var blogImage in blog.Images)
                {
                    string path = _env.GetFilePath("assets/images", blogImage.Image);
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                }
               

            }
        }

        public async Task EditAsync(BlogAuthorEditVM blogAuthor)
        {
            BlogAuthor dbBlogAuthor = await _context.BlogAuthors.AsNoTracking().FirstOrDefaultAsync(m => m.Id == blogAuthor.Id);

            _mapper.Map(blogAuthor, dbBlogAuthor);
            dbBlogAuthor.UpdatedDate=DateTime.Now;

            _context.BlogAuthors.Update(dbBlogAuthor);

            await _context.SaveChangesAsync();
        }

        public async Task<List<BlogAuthorVM>> GetAllAsync()
        {
            return _mapper.Map<List<BlogAuthorVM>>(await _context.BlogAuthors.ToListAsync());
        }

        public async Task<BlogAuthorVM> GetByIdWithoutTrackingAsync(int id)
        {
            return _mapper.Map<BlogAuthorVM>(await _context.BlogAuthors.Include(m=>m.Blogs).AsNoTracking()
                                                                       .FirstOrDefaultAsync(m => m.Id == id));
        }

        public async Task<BlogAuthorVM> GetByNameWithoutTrackingAsync(string name)
        {
            return _mapper.Map<BlogAuthorVM>(await _context.BlogAuthors.AsNoTracking()
                                                        .FirstOrDefaultAsync(m => m.FullName.Trim().ToLower() == name.Trim().ToLower()));
        }

        public Task<int> GetCountAsync()
        {
           return _context.BlogAuthors.CountAsync();
        }

        public async Task<List<BlogAuthorVM>> GetPaginatedDatasAsync(int page, int take)
        {
            return _mapper.Map<List<BlogAuthorVM>>(await _context.BlogAuthors.Include(m => m.Blogs)
                                                                             .Skip((page * take) - take)
                                                                             .Take(take)
                                                                             .ToListAsync());

        }


    }
}
