using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Pustok_Backend.Areas.Admin.ViewModels.Product;
using Pustok_Backend.Data;
using Pustok_Backend.Helpers.Responses;
using Pustok_Backend.Models;
using Pustok_Backend.Services.Interfaces;
using Pustok_Backend.ViewModels.Cart;

namespace Pustok_Backend.Services
{
    public class CartService:ICartService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IProductService _productService;
        private readonly AppDbContext _context;

        public CartService(IHttpContextAccessor httpContextAccessor, 
                           IProductService productService,
                            AppDbContext context)
        {
            _httpContextAccessor = httpContextAccessor;
            _productService = productService;
            _context = context;

        }

        public async Task<decimal> AddBasket(int id, ProductDetailVM product)
        {
            List<CartVM> basket;

            if (_httpContextAccessor.HttpContext.Request.Cookies["basket"] != null)
            {
                basket = JsonConvert.DeserializeObject<List<CartVM>>(_httpContextAccessor.HttpContext.Request.Cookies["basket"]);
            }
            else
            {
                basket = new List<CartVM>();
            }

            CartVM existProducts = basket.FirstOrDefault(m => m.Id == product.Id);

            if (existProducts is null)
            {
                basket.Add(new CartVM { Id = product.Id, Count = 1 });
            }
            else
            {
                existProducts.Count++;

            }

            List<decimal> grandTotal = new();

            _httpContextAccessor.HttpContext.Response.Cookies.Append("basket", JsonConvert.SerializeObject(basket));


            foreach (var item in basket)
            {
                var productById = await _productService.GetByIdWithoutTrackingAsync(item.Id);

                decimal price = productById.Price - ((productById.Price * productById.Discount) / 100);

                decimal total = item.Count * price;

                grandTotal.Add(total);
            }

           return grandTotal.Sum();
        }



        public async Task<decimal> AddBasketWithCount(int id,int count, ProductDetailVM product)
        {
            List<CartVM> basket;

            if (_httpContextAccessor.HttpContext.Request.Cookies["basket"] != null)
            {
                basket = JsonConvert.DeserializeObject<List<CartVM>>(_httpContextAccessor.HttpContext.Request.Cookies["basket"]);
            }
            else
            {
                basket = new List<CartVM>();
            }

            CartVM existProducts = basket.FirstOrDefault(m => m.Id == product.Id);

            if (existProducts is null)
            {
                basket.Add(new CartVM { Id = product.Id, Count = count });
            }
            else
            {
                existProducts.Count = existProducts.Count + count;

            }

            List<decimal> grandTotal = new();

            _httpContextAccessor.HttpContext.Response.Cookies.Append("basket", JsonConvert.SerializeObject(basket));


            foreach (var item in basket)
            {
                var productById = await _productService.GetByIdWithoutTrackingAsync(item.Id);

                decimal price = productById.Price - ((productById.Price * productById.Discount) / 100);

                decimal total = item.Count * price;

                grandTotal.Add(total);
            }

            return grandTotal.Sum();
        }

        public int GetCount()
        {
            List<CartVM> basket;

            if (_httpContextAccessor.HttpContext.Request.Cookies["basket"] != null)
            {
                basket = JsonConvert.DeserializeObject<List<CartVM>>(_httpContextAccessor.HttpContext.Request.Cookies["basket"]);
            }
            else
            {
                basket = new List<CartVM>();

            }

            return basket.Sum(m => m.Count);
        }


        public async Task<List<CartDetailVM>> GetBasketDatasAsync()
        {
            List<CartVM> basket;

            if (_httpContextAccessor.HttpContext.Request.Cookies["basket"] != null)
            {
                basket = JsonConvert.DeserializeObject<List<CartVM>>(_httpContextAccessor.HttpContext.Request.Cookies["basket"]);
            }
            else
            {
                basket = new List<CartVM>();

            }

            List<CartDetailVM> basketDetailList = new();

            foreach (var item in basket)
            {
                ProductDetailVM existProduct = await _productService.GetByIdWithoutTrackingAsync(item.Id);

                decimal price = existProduct.Price - ((existProduct.Price * existProduct.Discount) / 100);

                basketDetailList.Add(new CartDetailVM
                {
                    Id = existProduct.Id,
                    Name = existProduct.Name,
                    Price = price,
                    Count = item.Count,
                    Total = price * item.Count,
                    Image = existProduct.Images.FirstOrDefault(m=>m.IsMain).Image
                });
            }
            return basketDetailList;
        }

        public async Task<IncreaseOrDecreaseCountResponse> IncreaseCount(int id)
        {
            List<decimal> grandTotal = new();

            List<CartVM> basket = JsonConvert.DeserializeObject<List<CartVM>>(_httpContextAccessor.HttpContext.Request.Cookies["basket"]);

            CartVM existProduct = basket.FirstOrDefault(m => m.Id == id);

            existProduct.Count++;

            var basketItem = await _productService.GetByIdWithoutTrackingAsync(id);

            decimal price = basketItem.Price - ((basketItem.Price * basketItem.Discount) / 100);

            var productTotalPrice = existProduct.Count * price;

            foreach (var item in basket)
            {

                var product = await _productService.GetByIdWithoutTrackingAsync(item.Id);
                decimal productPrice = product.Price - ((product.Price*product.Discount) / 100);

                decimal total = item.Count * productPrice;

                grandTotal.Add(total);
            }

            _httpContextAccessor.HttpContext.Response.Cookies.Append("basket", JsonConvert.SerializeObject(basket));

            return new IncreaseOrDecreaseCountResponse
            {
                Count = existProduct.Count,
                GrandTotal = grandTotal.Sum(),
                ProductTotalPrice = productTotalPrice,
                CountBasket = basket.Sum(m => m.Count)

            };
        }

        public async Task<IncreaseOrDecreaseCountResponse> DecreaseCount(int id)
        {
            List<decimal> grandTotal = new();

            List<CartVM> basket = JsonConvert.DeserializeObject<List<CartVM>>(_httpContextAccessor.HttpContext.Request.Cookies["basket"]);
            CartVM existProduct = basket.FirstOrDefault(m => m.Id == id);


            if (existProduct.Count > 1)
            {

                existProduct.Count--;


            }
            foreach (var item in basket)
            {

                var product = await _productService.GetByIdWithoutTrackingAsync(item.Id);

                decimal productPrice= product.Price - ((product.Price * product.Discount) / 100);

                decimal total = item.Count * productPrice;

                grandTotal.Add(total);
            }

            _httpContextAccessor.HttpContext.Response.Cookies.Append("basket", JsonConvert.SerializeObject(basket));

            var basketItem = await _productService.GetByIdWithoutTrackingAsync(id);
            decimal price= basketItem.Price - ((basketItem.Price * basketItem.Discount) / 100);

            var productTotalPrice = existProduct.Count * price;
            return new IncreaseOrDecreaseCountResponse
            {
                Count = existProduct.Count,
                GrandTotal = grandTotal.Sum(),
                ProductTotalPrice = productTotalPrice,
                CountBasket = basket.Sum(m => m.Count)
            };
        }

        public async Task<DeleteBasketItemResponse> DeleteItem(int id)
        {
            List<decimal> grandTotal = new();

            List<CartVM> basket = JsonConvert.DeserializeObject<List<CartVM>>(_httpContextAccessor.HttpContext.Request.Cookies["basket"]);

            CartVM basketItem = basket.FirstOrDefault(m => m.Id == id);

            basket.Remove(basketItem);

            foreach (var item in basket)
            {
                var product = await _productService.GetByIdWithoutTrackingAsync(item.Id);

                decimal price =product.Price - ((product.Price * product.Discount) / 100);

                decimal total = item.Count * price;

                grandTotal.Add(total);
            }

            _httpContextAccessor.HttpContext.Response.Cookies.Append("basket", JsonConvert.SerializeObject(basket));

            return new DeleteBasketItemResponse
            {
                Count = basket.Sum(m => m.Count),
                GrandTotal = grandTotal.Sum()
            };
        }

        public  List<CartVM> GetDatasFromCookies()
        {
            var data = _httpContextAccessor.HttpContext.Request.Cookies["basket"];

            if (data is not null)
            {
                var basket = JsonConvert.DeserializeObject<List<CartVM>>(data);
                return basket;
            }
            else
            {
                return new List<CartVM>();
            }
        }

        public async Task<Cart> GetCartByUserIdAsync(string userId)
        {
            return await _context.Carts.Include(m=>m.CartProducts).FirstOrDefaultAsync(m => m.AppUserId == userId);
        }

        public async Task<List<CartProduct>> GetAllByBasketIdAsync(int? cartId)
        {
            return await _context.CartProducts.Where(m => m.CartId == cartId).ToListAsync();
        }

        public async Task< decimal> GetGrandTotal()
        {
            List<decimal> grandTotal = new();
            List<CartVM> basket;


            if (_httpContextAccessor.HttpContext.Request.Cookies["basket"] != null)
            {
                basket = JsonConvert.DeserializeObject<List<CartVM>>(_httpContextAccessor.HttpContext.Request.Cookies["basket"]);

                foreach (var item in basket)
                {
                    var product = await _productService.GetByIdWithoutTrackingAsync(item.Id);

                    decimal price = product.Price - ((product.Price * product.Discount) / 100);

                    decimal total = item.Count * price;

                    grandTotal.Add(total);
                }

            }

            return grandTotal.Sum();
        }
    }
}
