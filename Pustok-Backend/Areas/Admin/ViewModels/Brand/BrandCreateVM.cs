using System.ComponentModel.DataAnnotations;

namespace Pustok_Backend.Areas.Admin.ViewModels.Brand
{
    public class BrandCreateVM
    {
        [Required]
        public List<IFormFile> Photos { get; set; }
    }
}
