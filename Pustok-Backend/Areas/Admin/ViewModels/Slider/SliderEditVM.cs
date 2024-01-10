using System.ComponentModel.DataAnnotations;

namespace Pustok_Backend.Areas.Admin.ViewModels.Slider
{
    public class SliderEditVM
    {

        public int Id { get; set; }

        [Required]
        public string Header { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }

        public string Image { get; set; }

        public DateTime UpdatedDate { get; set; } = DateTime.Now;

        public IFormFile Photo { get; set; }
        public int DirectionId { get; set; }
    }
}
