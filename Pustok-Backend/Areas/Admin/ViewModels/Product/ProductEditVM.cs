using Microsoft.AspNetCore.Mvc.Rendering;
using Pustok_Backend.Models;
using System.ComponentModel.DataAnnotations;

namespace Pustok_Backend.Areas.Admin.ViewModels.Product
{
    public class ProductEditVM
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Name { get; set; }


        [Required]
        public string Sku { get; set; }

        [Required]
        public int StockCount { get; set; }

        [Required]
        public decimal Price { get; set; }
        public IList<SelectListItem> Tags { get; set; }

        public List<ProductImage> Images { get; set; }
        public List<IFormFile> Photos { get; set; }

        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public int DiscountId { get; set; }
    }
}
