using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pustok_Backend.Areas.Admin.ViewModels.BlogComment;
using Pustok_Backend.Areas.Admin.ViewModels.ProductComment;
using Pustok_Backend.Data;
using Pustok_Backend.Models;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Services
{
    public class ProductCommentService:IProductCommentService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ProductCommentService(AppDbContext context,
                                     IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateAsync(ProductComment comment)
        {

            await _context.ProductComments.AddAsync(comment);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int? id)
        {
            if (id is null) throw new ArgumentNullException();

            ProductComment dbProductComment = await _context.ProductComments.FirstOrDefaultAsync(m => m.Id == id);

            if (dbProductComment is null) throw new NullReferenceException();

            _context.ProductComments.Remove(dbProductComment);

            await _context.SaveChangesAsync();
        }

        public async Task<ProductCommentVM> GetByIdAsync(int id)
        {
            return _mapper.Map<ProductCommentVM>(await _context.ProductComments.Include(m => m.Product).Include(m => m.AppUser).FirstOrDefaultAsync(m => m.Id == id));
        }
        public async Task<int> GetCountAsync()
        {
            return await _context.ProductComments.CountAsync();
        }

        public async Task<List<ProductCommentVM>> GetAllAsync(int page, int take)
        {
            return _mapper.Map<List<ProductCommentVM>>(await _context.ProductComments.Include(m => m.Product)
                                                                               .Include(m => m.AppUser)
                                                                               .Skip((page * take) - take)
                                                                               .Take(take)
                                                                               .ToListAsync());
        }
    }
}
