using System.ComponentModel.DataAnnotations;

namespace Pustok_Backend.Areas.Admin.ViewModels.Advert
{
    public class AdvertEditVM
    {
        public int Id { get; set; }

        [Required]
        public string Header { get; set; }
        [Required]

        public string Title { get; set; }
        public string Image { get; set; }

        public IFormFile Photo { get; set; }
    }
}
