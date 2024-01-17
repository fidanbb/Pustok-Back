using AutoMapper;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pustok_Backend.Areas.Admin.ViewModels.Blog;
using Pustok_Backend.Areas.Admin.ViewModels.BlogComment;
using Pustok_Backend.Data;
using Pustok_Backend.Models;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Services
{
    public class BlogService : IBlogService
    {
        private readonly AppDbContext _context;

        private readonly IMapper _mapper;

        public BlogService(AppDbContext context,
                           IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateCommentAsync(BlogComment comment)
        {

            await _context.BlogComments.AddAsync(comment);
            await _context.SaveChangesAsync();
        }

        public async Task<List<BlogVM>> GetAllWithTakeInDescendingOrderAsync(int take)
        {
            return _mapper.Map<List<BlogVM>>(await _context.Blogs.Include(m => m.Images)
                                                                 .Include(m => m.BlogAuthor)
                                                                 .Take(take)
                                                                 .OrderByDescending(m=>m.CreatedDate)
                                                                 .ToListAsync());
        }

        public async Task<BlogDetailVM> GetByIdWithoutTrackingAsync(int id)
        {
            return _mapper.Map<BlogDetailVM>(await _context.Blogs.Include(m => m.BlogAuthor)
                                                                 .Include(m => m.Images)
                                                                 .Include(m => m.BlogComments)
                                                                 .Include(m => m.BlogTags)
                                                                 .ThenInclude(m => m.Tag)
                                                                 .AsNoTracking()
                                                                 .FirstOrDefaultAsync(m => m.Id == id));
        }

        public async Task<int> GetCountAsync(int? tagId,int? month, string searchText)
        {
            int count= await _context.Blogs.CountAsync();
            if(tagId is not null)
            {
                count= await _context.Blogs.Where(blog => blog.BlogTags.Any(blogTag => blogTag.TagId == tagId)).CountAsync();
                                                                
            }
            if(searchText is not null)
            {
                count = await _context.Blogs.Where(m => m.Title.ToLower().Trim().Contains(searchText.ToLower().Trim())).CountAsync();                                             
                                                            
            }


            if (month != null)
            {
                count =await _context.Blogs.Where(m => m.CreatedDate.Month == month).CountAsync();
                                                                 
            }

            return count;
        }



        public async Task<List<(int Month, int Count)>> GetDatesOfDatasAsync()
        {
            var dateCounts = await _context.Blogs
                .GroupBy(blog => blog.CreatedDate.Month)
                .Select(group => new
                {
                    Month = group.Key,
                    Count = group.Count()
                })
                .ToListAsync();

            return dateCounts.Select(dc => (dc.Month, dc.Count)).ToList();
        }

        public async Task<List<BlogVM>> GetPaginatedDatasAsync(int page, int take, int? tagId,int? month, string searchText)
        {
            List<BlogVM> blogs= _mapper.Map<List<BlogVM>>(await _context.Blogs.Include(m => m.Images)
                                                                 .Include(m => m.BlogAuthor)
                                                                 .Include(m=>m.BlogTags)
                                                                 .ThenInclude(m=>m.Tag)
                                                                 .Skip((page * take) - take)
                                                                 .Take(take)
                                                                 .ToListAsync());

            if(searchText != null)
            {
                blogs = _mapper.Map<List<BlogVM>>(await _context.Blogs.Include(m => m.Images)
                                                                 .Include(m => m.BlogAuthor)
                                                                 .Include(m => m.BlogTags)
                                                                 .ThenInclude(m => m.Tag)
                                                                 .Where(m=>m.Title.ToLower().Trim().Contains(searchText.ToLower().Trim()))
                                                                 .Skip((page * take) - take)
                                                                 .Take(take)
                                                                 .ToListAsync());
            }

            if(month != null)
            {
                blogs =_mapper.Map<List<BlogVM>>(await _context.Blogs.Include(m => m.Images)
                                                                 .Include(m => m.BlogAuthor)
                                                                 .Include(m => m.BlogTags)
                                                                 .ThenInclude(m => m.Tag)
                                                                 .Where(m=>m.CreatedDate.Month ==month)
                                                                 .Skip((page * take) - take)
                                                                 .Take(take)
                                                                 .ToListAsync());
            }

            if (tagId!=null)
            {
                //return _mapper.Map<List<BlogVM>>(await _context.BlogTags.Include(m => m.Blog)
                //                                                 .ThenInclude(m=>m.Images)
                //                                                 .Include(m => m.Blog)
                //                                                 .ThenInclude(m=>m.BlogAuthor)
                //                                                 .Where(m=>m.TagId==tagId)
                //                                                 .Skip((page * take) - take)
                //                                                 .Take(take)
                //                                                 .Select(m=>m.Blog)
                //                                                 .ToListAsync());


                return _mapper.Map<List<BlogVM>>(await _context.Blogs
                                                                 .Include(m => m.Images)
                                                                 .Include(m => m.BlogAuthor)
                                                                 .Where(blog => blog.BlogTags.Any(blogTag => blogTag.TagId == tagId))
                                                                 .Skip((page * take) - take)
                                                                 .Take(take)
                                                                 .ToListAsync());
            }


            return blogs;
        }

        public async Task<List<BlogVM>> GetRelatedDatasAsync(BlogDetailVM currentBlog, int take)
        {
            var tagIds = currentBlog.Tags.Select(t => t.Id);
            return _mapper.Map<List<BlogVM>>(await _context.Blogs.Include(m => m.Images)
                                                          .Include(m => m.BlogAuthor)
                                                          .Include(m => m.BlogTags)
                                                          .ThenInclude(m => m.Tag)
                                                         .Where(blog => blog.Id != currentBlog.Id)
        .Where(blog => blog.BlogTags.Any(tag => tagIds.Contains(tag.Tag.Id)))
                                                        
                                                          .Take(take)
                                                          .ToListAsync());
        }
    }
}
