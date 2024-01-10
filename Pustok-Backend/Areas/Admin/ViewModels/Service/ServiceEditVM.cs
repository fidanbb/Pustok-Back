using System.ComponentModel.DataAnnotations;

namespace Pustok_Backend.Areas.Admin.ViewModels.Service
{
    public class ServiceEditVM
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]

        public string Description { get; set; }
        [Required]

        public string IconName { get; set; }

    }
}
