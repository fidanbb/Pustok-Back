using AutoMapper;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Pustok_Backend.Areas.Admin.ViewModels.Blog;
using Pustok_Backend.Areas.Admin.ViewModels.Product;
using Pustok_Backend.Data;
using Pustok_Backend.Models;
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


        public async Task<List<ProductVM>> GetRelatedDatasAsync(ProductDetailVM currentProduct, int take)
        {
            var tagIds = currentProduct.Tags.Select(t => t.Id);
            return _mapper.Map<List<ProductVM>>(await _context.Products.Include(m => m.Images)
                                                          .Include(m => m.Author)
                                                          .Include(m => m.ProductTags)
                                                          .ThenInclude(m => m.Tag)
                                                         .Where(product => product.Id != currentProduct.Id)
                                                         .Where(product => product.ProductTags.Any(tag => tagIds.Contains(tag.Tag.Id)))
                                                          .Take(take)
                                                          .ToListAsync());
        }

        public async Task<List<ProductVM>> GetBestSellerProductsAsync()
        {
            return _mapper.Map<List<ProductVM>>(await _context.Products.Include(m => m.Images)
                                                                    .Include(m => m.Author)
                                                                    .Include(m => m.Discount)
                                                                    .OrderByDescending(m => m.SaleCount)
                                                                    .ToListAsync());
        }

        public async Task<ProductDetailVM> GetByIdWithoutTrackingAsync(int id)
        {
            return _mapper.Map<ProductDetailVM>(await _context.Products.Include(m => m.Images)
                                                                       .Include(m => m.Discount)
                                                                       .Include(m => m.Author)
                                                                       .Include(m => m.ProductComments)
                                                                       .Include(m=>m.Category)
                                                                       .Include(m => m.ProductTags)
                                                                       .ThenInclude(m => m.Tag)
                                                                       .AsNoTracking()
                                                                       .FirstOrDefaultAsync(m => m.Id == id));
        }

        public async Task<int> GetCountAsync(int? categoryId, string sortValue, string searchText, int? minValue, int? maxValue)
        {
            int count = await _context.Products.CountAsync();


            if (searchText != null)
            {
                count = await _context.Products.Where(m => m.Name.ToLower().Trim().Contains(searchText.ToLower().Trim())
                                                       || m.Author.FullName.ToLower().Trim().Contains(searchText.ToLower().Trim())
                                                       || m.Category.Name.ToLower().Trim().Contains(searchText.ToLower().Trim()))
                                               .CountAsync();
                                                                      
            }

            if (categoryId != null)
            {
                count = await _context.Products.Where(m => m.CategoryId == categoryId)
                                               .CountAsync();
                                                                      
            }

            if (minValue != null && maxValue != null)
            {
                count = await _context.Products.Where(p => p.Price >= minValue && p.Price <= maxValue)
                                               .CountAsync();
                                                                     

            }

            if (sortValue != null)
            {
                switch (sortValue)
                {
                    case "2":
                        {
                            return await _context.Products.OrderByDescending(m => m.CreatedDate).CountAsync();
                        }
                    case "3":
                        {
                            return await _context.Products.OrderBy(m => m.Name).CountAsync();
                        }
                    case "4":
                        {
                            return await _context.Products.OrderByDescending(m => m.Name).CountAsync();

                        }

                    case "5":
                        {
                           return await _context.Products.OrderByDescending(m => m.Rate).CountAsync();

                        }

                    case "6":
                        {
                           return await _context.Products.OrderBy(m => m.Price).CountAsync();

                        }

                    case "7":
                        {
                          return await _context.Products.OrderByDescending(m => m.Price).CountAsync();

                        }
                    default:
                        {
                           return await _context.Products.OrderByDescending(m => m.CreatedDate).CountAsync();

                        }
                }
            }

                return count;
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

        public async Task<List<ProductVM>> GetPaginatedDatasAsync(int page, int take, int? categoryId, string sortValue, string searchText, int? minValue, int? maxValue)
        {
            List<ProductVM> products =_mapper.Map<List<ProductVM>>(await _context.Products.Include(m => m.Images)
                                                                       .Include(m => m.Author)
                                                                       .Include(m => m.Discount)
                                                                       .Skip((page * take) - take)
                                                                       .Take(take)
                                                                       .ToListAsync());

            if (searchText != null)
            {
                products = _mapper.Map<List<ProductVM>>(await _context.Products.Include(m => m.Images)
                                                                       .Include(m => m.Author)
                                                                       .Include(m => m.Discount)
                                                                       .Where(m => m.Name.ToLower().Trim().Contains(searchText.ToLower().Trim())
                                                                        || m.Author.FullName.ToLower().Trim().Contains(searchText.ToLower().Trim())
                                                                        || m.Category.Name.ToLower().Trim().Contains(searchText.ToLower().Trim()))
                                                                       .Skip((page * take) - take)
                                                                       .Take(take)
                                                                       .ToListAsync());
            }

            if(categoryId != null)
            {
                return _mapper.Map<List<ProductVM>>(await _context.Products.Include(m => m.Images)
                                                                       .Include(m => m.Author)
                                                                       .Include(m => m.Discount)
                                                                       .Where(m=>m.CategoryId==categoryId)
                                                                       .Skip((page * take) - take)
                                                                       .Take(take)
                                                                       .ToListAsync());
            }

            if (minValue != null && maxValue != null)
            {
                products = _mapper.Map<List<ProductVM>>(await _context.Products.Include(m => m.Images)
                                                                       .Include(m => m.Author)
                                                                       .Include(m => m.Discount)
                                                                       .Where(p => p.Price >= minValue && p.Price <= maxValue)
                                                                       .Skip((page * take) - take)
                                                                       .Take(take)
                                                                       .ToListAsync());

            }

            if (sortValue !=null)
            {
                switch (sortValue)
                {
                    case "2":
                        {
                            return _mapper.Map<List<ProductVM>>(await _context.Products.Include(m => m.Images)
                                                                     .Include(m => m.Author)
                                                                     .Include(m => m.Discount)
                                                                     .OrderByDescending(m => m.CreatedDate)
                                                                     .Skip((page * take) - take)
                                                                     .Take(take)
                                                                     .ToListAsync());
                        }
                    case "3":
                        {
                            return _mapper.Map<List<ProductVM>>(await _context.Products.Include(m => m.Images)
                                                                       .Include(m => m.Author)
                                                                       .Include(m => m.Discount)
                                                                       .OrderBy(m => m.Name)
                                                                       .Skip((page * take) - take)
                                                                       .Take(take)
                                                                       .ToListAsync());
                        }
                    case "4":
                        {
                            return _mapper.Map<List<ProductVM>>(await _context.Products.Include(m => m.Images)
                                                                       .Include(m => m.Author)
                                                                       .Include(m => m.Discount)
                                                                       .OrderByDescending(m => m.Name)
                                                                       .Skip((page * take) - take)
                                                                       .Take(take)
                                                                       .ToListAsync());
                        }

                    case "5":
                        {
                            return _mapper.Map<List<ProductVM>>(await _context.Products.Include(m => m.Images)
                                                                       .Include(m => m.Author)
                                                                       .Include(m => m.Discount)
                                                                       .OrderByDescending(m => m.Rate)
                                                                       .Skip((page * take) - take)
                                                                       .Take(take)
                                                                       .ToListAsync());
                        }

                    case "6":
                        {
                            return _mapper.Map<List<ProductVM>>(await _context.Products.Include(m => m.Images)
                                                                       .Include(m => m.Author)
                                                                       .Include(m => m.Discount)
                                                                       .OrderBy(m => m.Price)
                                                                       .Skip((page * take) - take)
                                                                       .Take(take)
                                                                       .ToListAsync());
                        }

                    case "7":
                        {
                            return _mapper.Map<List<ProductVM>>(await _context.Products.Include(m => m.Images)
                                                                       .Include(m => m.Author)
                                                                       .Include(m => m.Discount)
                                                                       .OrderByDescending(m => m.Price)
                                                                       .Skip((page * take) - take)
                                                                       .Take(take)
                                                                       .ToListAsync());
                        }
                    default:
                        {
                            return _mapper.Map<List<ProductVM>>(await _context.Products.Include(m => m.Images)
                                                                      .Include(m => m.Author)
                                                                      .Include(m => m.Discount)
                                                                      .OrderByDescending(m => m.CreatedDate)
                                                                      .Skip((page * take) - take)
                                                                      .Take(take)
                                                                      .ToListAsync());
                        }
                }
            }



            return products;
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

        public async Task<List<ProductVM>> GetTopProducts(int take)
        {
            return _mapper.Map<List<ProductVM>>(await _context.Products.Include(m => m.Images)
                                                                    .Include(m => m.Author)
                                                                    .Include(m => m.Discount)
                                                                    .OrderByDescending(m=>m.Rate)
                                                                    .Take(take)
                                                                    .ToListAsync());
        }

        public async Task<int> GetTotalProductCountAsync()
        {
           return await _context.Products.CountAsync();
        }
    }
}
