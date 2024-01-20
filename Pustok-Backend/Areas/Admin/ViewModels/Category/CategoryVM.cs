using Pustok_Backend.Models;

namespace Pustok_Backend.Areas.Admin.ViewModels.Category
{
    public class CategoryVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Models.Product> Products { get; set; }
    }
}
