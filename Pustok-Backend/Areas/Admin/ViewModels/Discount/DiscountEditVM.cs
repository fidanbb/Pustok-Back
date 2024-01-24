using System.ComponentModel.DataAnnotations;

namespace Pustok_Backend.Areas.Admin.ViewModels.Discount
{
    public class DiscountEditVM
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, 99, ErrorMessage = "Enter percent between 1 to 99")]
        public int Percent { get; set; }
    }
}
