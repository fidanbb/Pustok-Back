using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pustok_Backend.Areas.Admin.ViewModels.Product;
using Pustok_Backend.Data;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ProductService(AppDbContext context,
                               IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ProductVM>> GetBestSellerProductsAsync()
        {
            return _mapper.Map<List<ProductVM>>(await _context.Products.Include(m => m.Images)
                                                                    .Include(m => m.Author)
                                                                    .Include(m => m.Discount)
                                                                    .OrderByDescending(m => m.SaleCount)
                                                                    .ToListAsync());
        }

        public async Task<List<ProductVM>> GetDealOfTheDayProductsWithTakeAsync(int take)
        {
            return _mapper.Map<List<ProductVM>>(await _context.Products.Include(m => m.Images)
                                                                       .Include(m => m.Author)
                                                                       .Include(m => m.Discount)
                                                                       .Where(m => m.Discount.Percent==20)
                                                                       .Take(take)
                                                                       .ToListAsync());
        }

        public async Task<List<ProductVM>> GetFeaturedProductsWithTakeAsync(int take)
        {
            return _mapper.Map<List<ProductVM>>(await _context.Products.Include(m => m.Images)
                                                                       .Include(m => m.Author)
                                                                       .Include(m => m.Discount)
                                                                       .OrderByDescending(m=>m.Discount)
                                                                       .Take(take)
                                                                       .ToListAsync());
        }

        public async Task<List<ProductVM>> GetMostViewedProductsWithTakeAsync(int take)
        {
            return _mapper.Map<List<ProductVM>>(await _context.Products.Include(m => m.Images)
                                                                      .Include(m => m.Author)
                                                                      .Include(m => m.Discount)
                                                                      .OrderByDescending(m => m.SaleCount)
                                                                      .Take(take)
                                                                      .ToListAsync());
        }

        public async Task<List<ProductVM>> GetNewArrivedProductsWithTakeAsync(int take)
        {
            return _mapper.Map<List<ProductVM>>(await _context.Products.Include(m => m.Images)
                                                                       .Include(m => m.Author)
                                                                       .Include(m => m.Discount)
                                                                       .OrderByDescending(m => m.CreatedDate)
                                                                       .Take(take)
                                                                       .ToListAsync());
        }

        public async Task<List<ProductVM>> GetProductsByCategoryWithTakeAsync(int take, string categoryName)
        {
            return _mapper.Map<List<ProductVM>>(await _context.Products.Include(m => m.Images)
                                                                    .Include(m => m.Author)
                                                                    .Include(m => m.Discount)
                                                                    .Where(m => m.Category.Name.Trim().ToLower()==categoryName.Trim().ToLower())
                                                                    .Take(take)
                                                                    .ToListAsync());
        }
    }
}
