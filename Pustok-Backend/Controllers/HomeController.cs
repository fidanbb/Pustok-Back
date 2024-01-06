using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Pustok_Backend.Controllers
{
    public class HomeController : Controller
    {
       public IActionResult Index()
        {
            return View();
        }
    }
}
