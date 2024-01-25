using Microsoft.AspNetCore.Mvc;
using Pustok_Backend.Services.Interfaces;
using Pustok_Backend.ViewModels.Wishlist;

namespace Pustok_Backend.Controllers
{
    public class WishlistController : Controller
    {
        private readonly IWishlistService _wishlistService;

        public WishlistController(IWishlistService wishlistService)
        {
            _wishlistService = wishlistService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _wishlistService.GetWishlistDatasAsync());
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _wishlistService.DeleteItem(id);
            List<WishlistVM> wishlist = _wishlistService.GetDatasFromCookies();

            return Ok(wishlist.Count);
        }
    }
}
