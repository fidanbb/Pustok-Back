using Pustok_Backend.Areas.Admin.ViewModels.Category;
using Pustok_Backend.Areas.Admin.ViewModels.Social;
using Pustok_Backend.ViewModels.Cart;

namespace Pustok_Backend.ViewModels.Layout
{
    public class HeaderVM
    {
        public string HeaderLogo { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string UserFullName { get; set; }
        public int BasketCount { get; set; }
        public decimal TotalPrice { get; set; }
        public List<CategoryVM> Categories { get; set; }

        public List<CartDetailVM> Cart { get; set; }


    }
}
