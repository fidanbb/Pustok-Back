using Pustok_Backend.Areas.Admin.ViewModels.Product;
using Pustok_Backend.Models;
using Pustok_Backend.ViewModels.Wishlist;

namespace Pustok_Backend.Services.Interfaces
{
    public interface IWishlistService
    {
        bool AddWishlist(int id, ProductDetailVM product);
        Task<List<WishlistDetailVM>> GetWishlistDatasAsync();
        void DeleteItem(int id);

        List<WishlistVM> GetDatasFromCookies();
        void SetDatasToCookies(List<WishlistVM> wishlist, Product dbProduct, WishlistVM existProduct);
        Task<Wishlist> GetWishlistByUserIdAsync(string userId);
        Task<List<WishlistProduct>> GetAllByWishlistIdAsync(int? wishlistId);
    }
}
