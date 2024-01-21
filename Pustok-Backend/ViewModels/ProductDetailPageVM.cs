using Pustok_Backend.Areas.Admin.ViewModels.Product;
using Pustok_Backend.Areas.Admin.ViewModels.ProductComment;

namespace Pustok_Backend.ViewModels
{
    public class ProductDetailPageVM
    {
        public ProductDetailVM Product { get; set; }
        public List<ProductVM> RelatedProducts { get; set; }
        public ProductCommentCreateVM ProductComment { get; set; }
    }
}
