using System.ComponentModel.DataAnnotations;

namespace Pustok_Backend.Areas.Admin.ViewModels.Subscribe
{
    public class SubscribeCreateVM
    {
        [Required]
        public string Email { get; set; }
    }
}
