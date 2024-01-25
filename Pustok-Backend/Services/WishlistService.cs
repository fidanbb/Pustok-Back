using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Pustok_Backend.Areas.Admin.ViewModels.Product;
using Pustok_Backend.Data;
using Pustok_Backend.Models;
using Pustok_Backend.Services.Interfaces;
using Pustok_Backend.ViewModels.Wishlist;

namespace Pustok_Backend.Services
{
    public class WishlistService:IWishlistService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IProductService _productService;
        private readonly AppDbContext _context;
        public WishlistService(IHttpContextAccessor httpContextAccessor,
                               IProductService productService,
                               AppDbContext context)
        {
            _httpContextAccessor = httpContextAccessor;
            _productService = productService;
            _context = context;
        }

        public bool AddWishlist(int id, ProductDetailVM product)
        {
            List<WishlistVM> wishlist;
            bool isInWishlist=true;

            if (_httpContextAccessor.HttpContext.Request.Cookies["wishlist"] != null)
            {
                wishlist = JsonConvert.DeserializeObject<List<WishlistVM>>(_httpContextAccessor.HttpContext.Request.Cookies["wishlist"]);
            }
            else
            {
                wishlist = new List<WishlistVM>();
            }



            WishlistVM existProducts = wishlist.FirstOrDefault(m => m.ProductId == product.Id);

            if (existProducts is null)
            {
                wishlist.Add(new WishlistVM { ProductId = product.Id });
                isInWishlist = false;
            }


            _httpContextAccessor.HttpContext.Response.Cookies.Append("wishlist", JsonConvert.SerializeObject(wishlist));

            return isInWishlist;
        }

        public async Task<List<WishlistDetailVM>> GetWishlistDatasAsync()
        {
            List<WishlistVM> wishlist;

            if (_httpContextAccessor.HttpContext.Request.Cookies["wishlist"] != null)
            {
                wishlist = JsonConvert.DeserializeObject<List<WishlistVM>>(_httpContextAccessor.HttpContext.Request.Cookies["wishlist"]);
            }
            else
            {
                wishlist = new List<WishlistVM>();

            }

            List<WishlistDetailVM> wishlistDetails = new();
            foreach (var item in wishlist)
            {
                ProductDetailVM existProduct = await _productService.GetByIdWithoutTrackingAsync(item.ProductId);

                wishlistDetails.Add(new WishlistDetailVM
                {
                    Id = existProduct.Id,
                    Name = existProduct.Name,
                    Price = existProduct.Price,
                    Discount = existProduct.Discount,
                    CreatedDate = existProduct.CreatedDate,
                    StockCount = existProduct.StockCount,
                    Image = existProduct.Images.FirstOrDefault(m=>m.IsMain).Image
                });
            }
            return wishlistDetails;
        }

        public void DeleteItem(int id)
        {

            List<WishlistVM> wishlist = JsonConvert.DeserializeObject<List<WishlistVM>>(_httpContextAccessor.HttpContext.Request.Cookies["wishlist"]);

            WishlistVM wishlistItem = wishlist.FirstOrDefault(m => m.ProductId == id);

            wishlist.Remove(wishlistItem);

            _httpContextAccessor.HttpContext.Response.Cookies.Append("wishlist", JsonConvert.SerializeObject(wishlist));

        }

        public List<WishlistVM> GetDatasFromCookies()
        {
            var data = _httpContextAccessor.HttpContext.Request.Cookies["wishlist"];

            if (data is not null)
            {
                var wishlist = JsonConvert.DeserializeObject<List<WishlistVM>>(data);
                return wishlist;
            }
            else
            {
                return new List<WishlistVM>();
            }

        }

        public void SetDatasToCookies(List<WishlistVM> wishlist, Product dbProduct, WishlistVM existProduct)
        {
            if (existProduct == null)
            {
                wishlist.Add(new WishlistVM
                {
                    ProductId = dbProduct.Id
                });
            }

            _httpContextAccessor.HttpContext.Response.Cookies.Append("wishlist", JsonConvert.SerializeObject(wishlist));
        }

        public async Task<Wishlist> GetWishlistByUserIdAsync(string userId)
        {
            return await _context.Wishlists.Include(m => m.WishlistProducts).FirstOrDefaultAsync(m => m.AppUserId == userId);
        }
        public async Task<List<WishlistProduct>> GetAllByWishlistIdAsync(int? wishlistId)
        {
            return await _context.WishlistProducts.Where(m => m.WishlistId == wishlistId).ToListAsync();
        }

    }
}
