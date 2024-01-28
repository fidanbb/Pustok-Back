using Pustok_Backend.Areas.Admin.ViewModels.Product;
using Pustok_Backend.Helpers.Responses;
using Pustok_Backend.Models;
using Pustok_Backend.ViewModels.Cart;

namespace Pustok_Backend.Services.Interfaces
{
    public interface ICartService
    {
        Task<decimal> AddBasket(int id, ProductDetailVM product);
        Task<decimal> AddBasketWithCount(int id,int count, ProductDetailVM product);


        int GetCount();
        Task<decimal> GetGrandTotal();
        Task<List<CartDetailVM>> GetBasketDatasAsync();


        Task<IncreaseOrDecreaseCountResponse> IncreaseCount(int id);
        Task<IncreaseOrDecreaseCountResponse> DecreaseCount(int id);
        Task<DeleteBasketItemResponse> DeleteItem(int id);
        List<CartVM> GetDatasFromCookies();
        Task<Cart> GetCartByUserIdAsync(string userId);
        Task<List<CartProduct>> GetAllByBasketIdAsync(int? cartId);
    }
}
