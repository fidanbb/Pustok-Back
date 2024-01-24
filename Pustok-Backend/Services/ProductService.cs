using AutoMapper;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Pustok_Backend.Areas.Admin.ViewModels.Blog;
using Pustok_Backend.Areas.Admin.ViewModels.Product;
using Pustok_Backend.Data;
using Pustok_Backend.Helpers.Extensions;
using Pustok_Backend.Models;
using Pustok_Backend.Services.Interfaces;
using System.Reflection.Metadata;

namespace Pustok_Backend.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;

        public ProductService(AppDbContext context,
                               IMapper mapper,
                               IWebHostEnvironment env)
        {
            _context = context;
            _mapper = mapper;
            _env = env;

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

        public async Task<List<ProductVM>> GetPaginatedProductDatasAsync(int page, int take)
        {
            return _mapper.Map<List<ProductVM>>(await _context.Products.Include(m => m.Images)
                                                                 .Include(m => m.Author)
                                                                 .Include(m=>m.Category)
                                                                 .Skip((page * take) - take)
                                                                 .Take(take)
                                                                 .ToListAsync());
        }

        public async Task DeleteAsync(int id)
        {
            Product dbProduct = await _context.Products.Include(m => m.Images).Include(m => m.ProductTags).Include(m => m.ProductComments).FirstOrDefaultAsync(m => m.Id == id);

            _context.Products.Remove(dbProduct);

            await _context.SaveChangesAsync();

            foreach (var item in dbProduct.Images)
            {
                string path = _env.GetFilePath("assets/images", item.Image);
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

            }
        }

        public async Task DeleteProductImageAsync(int id)
        {
            ProductImage productImage = await _context.ProductImages.Where(m => m.Id == id).FirstOrDefaultAsync();

            _context.Remove(productImage);

            await _context.SaveChangesAsync();

            string path = _env.GetFilePath("assets/images", productImage.Image);

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public async Task CreateAsync(ProductCreateVM product)
        {
            List<ProductImage> newImages = new();

            foreach (var photo in product.Photos)
            {
                string fileName = $"{Guid.NewGuid()}-{photo.FileName}";

                string path = _env.GetFilePath("assets/images", fileName);

                await photo.SaveFileAsync(path);

                newImages.Add(new ProductImage { Image = fileName });
            }

            newImages.FirstOrDefault().IsMain = true;



            var selectedTags = product.Tags.Where(m => m.Selected).Select(m => m.Value).ToList();




            var dbProduct = new Product()
            {
                Name = product.Name,
                Description = product.Description,
                Price =product.Price,
                Sku=product.Sku,
                StockCount=product.StockCount,
                Images = newImages,
                AuthorId = product.AuthorId,
                CategoryId=product.CategoryId,
                DiscountId=product.DiscountId,
                
            };

            foreach (var item in selectedTags)
            {
                dbProduct.ProductTags.Add(new ProductTag()
                {
                    TagId = int.Parse(item)
                });
            }

            await _context.ProductImages.AddRangeAsync(newImages);

            await _context.Products.AddAsync(dbProduct);
            await _context.SaveChangesAsync();
        }

        public async Task<ProductVM> GetByNameWithoutTrackingAsync(string name)
        {
            Product product = await _context.Products.Where(m => m.Name.Trim().ToLower() == name.Trim().ToLower()).FirstOrDefaultAsync();

            return _mapper.Map<ProductVM>(product);
        }

        public async Task EditAsync(ProductEditVM product)
        {
            List<ProductImage> newImages = new();

            if (product.Photos != null)
            {
                foreach (var photo in product.Photos)
                {
                    string fileName = $"{Guid.NewGuid()} - {photo.FileName}";

                    string path = _env.GetFilePath("assets/images", fileName);

                    await photo.SaveFileAsync(path);

                    newImages.Add(new ProductImage { Image = fileName });
                }

                await _context.ProductImages.AddRangeAsync(newImages);
            }

            newImages.AddRange(product.Images);


            var productById = await _context.Products.Include(m => m.ProductTags).FirstOrDefaultAsync(m => m.Id == product.Id);

            var existingIds = productById.ProductTags.Select(m => m.TagId).ToList();

            var selectedIds = product.Tags.Where(m => m.Selected).Select(m => m.Value).Select(int.Parse).ToList();

            var toAdd = selectedIds.Except(existingIds);
            var toRemove = existingIds.Except(selectedIds);

            productById.ProductTags = productById.ProductTags.Where(m => !toRemove.Contains(m.TagId)).ToList();

            foreach (var item in toAdd)
            {
                productById.ProductTags.Add(new ProductTag
                {
                    TagId = item
                });
            }


            product.Images = newImages;

            _mapper.Map(product, productById);

            _context.Products.Update(productById);

            await _context.SaveChangesAsync();
        }
    }
}
