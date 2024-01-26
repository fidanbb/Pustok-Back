using Microsoft.AspNetCore.Mvc;
using Pustok_Backend.Services.Interfaces;

namespace Pustok_Backend.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _cartService.GetBasketDatasAsync());
        }

        [HttpPost]
        public async Task<IActionResult> IncreaseCount(int id)
        {
            var data = await _cartService.IncreaseCount(id);
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> DecreaseCount(int id)
        {
            var data = await _cartService.DecreaseCount(id);
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _cartService.DeleteItem(id);

            return Ok(data);
        }
    }
}
