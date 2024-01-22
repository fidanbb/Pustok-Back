using Pustok_Backend.Areas.Admin.ViewModels.Category;
using Pustok_Backend.Areas.Admin.ViewModels.Product;
using Pustok_Backend.Helpers;

namespace Pustok_Backend.ViewModels
{
    public class ShopVM
    {
        public Paginate<ProductVM> PaginatedDatas { get; set; }
        public List<CategoryVM> Categories { get; set; }
        public List<ProductVM> TopProducts { get; set; }
        public ProductDetailVM ModalProduct { get; set; }


    }
}
