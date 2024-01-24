using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pustok_Backend.Areas.Admin.ViewModels.Category;
using Pustok_Backend.Areas.Admin.ViewModels.Discount;
using Pustok_Backend.Data;
using Pustok_Backend.Helpers.Extensions;
using Pustok_Backend.Models;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Services
{
    public class DiscountService:IDiscountService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;

        public DiscountService(AppDbContext context,
                             IMapper mapper,
                             IWebHostEnvironment env)
        {
            _context = context;
            _mapper = mapper;
            _env = env;

        }

        public async Task CreateAsync(DiscountCreateVM discount)
        {
            Discount dbDiscount = _mapper.Map<Discount>(discount);

            await _context.Discounts.AddAsync(dbDiscount);
            await _context.SaveChangesAsync();
        }


        public async Task DeleteAsync(int id)
        {
            Discount dbDiscount = await _context.Discounts.Where(m => m.Id == id).Include(m => m.Products).ThenInclude(m => m.Images).FirstOrDefaultAsync();
            _context.Discounts.Remove(dbDiscount);
            await _context.SaveChangesAsync();

            foreach (var product in dbDiscount.Products)
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


        public async Task EditAsync(DiscountEditVM discount)
        {
            Discount dbDiscount = await _context.Discounts.AsNoTracking().FirstOrDefaultAsync(m => m.Id == discount.Id);

            _mapper.Map(discount, dbDiscount);
            dbDiscount.UpdatedDate = DateTime.Now;

            _context.Discounts.Update(dbDiscount);

            await _context.SaveChangesAsync();
        }

        public async Task<List<DiscountVM>> GetAllAsync()
        {
            return _mapper.Map<List<DiscountVM>>(await _context.Discounts.ToListAsync());
        }

        public async Task<DiscountVM> GetByIdWithoutTrackingAsync(int id)
        {
            return _mapper.Map<DiscountVM>(await _context.Discounts.Include(m => m.Products).AsNoTracking()
                                                                      .FirstOrDefaultAsync(m => m.Id == id));
        }

        public async Task<DiscountVM> GetByNameWithoutTrackingAsync(string name)
        {
            return _mapper.Map<DiscountVM>(await _context.Discounts.AsNoTracking()
                                                         .FirstOrDefaultAsync(m => m.Name.Trim().ToLower() == name.Trim().ToLower()));
        }
        public Task<int> GetCountAsync()
        {
            return _context.Discounts.CountAsync();
        }

        public async Task<List<DiscountVM>> GetPaginatedDatasAsync(int page, int take)
        {
            return _mapper.Map<List<DiscountVM>>(await _context.Discounts.Include(m => m.Products)
                                                                             .Skip((page * take) - take)
                                                                             .Take(take)
                                                                             .ToListAsync());

        }
    }
}
