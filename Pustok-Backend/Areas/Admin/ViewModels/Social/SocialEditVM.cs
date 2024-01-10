using System.ComponentModel.DataAnnotations;

namespace Pustok_Backend.Areas.Admin.ViewModels.Social
{
    public class SocialEditVM
    {
        public int Id { get; set; }

        [Required]
        public string IconName { get; set; }

        [Required]

        public string Link { get; set; }
    }
}
