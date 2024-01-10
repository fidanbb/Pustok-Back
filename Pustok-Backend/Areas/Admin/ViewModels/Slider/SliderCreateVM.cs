using System.ComponentModel.DataAnnotations;

namespace Pustok_Backend.Areas.Admin.ViewModels.Slider
{
    public class SliderCreateVM
    {
        [Required]
        public string Header { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
        [Required]
        public IFormFile Photo { get; set; }
        public int DirectionId { get; set; }
    }
}
