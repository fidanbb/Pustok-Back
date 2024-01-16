using Pustok_Backend.Areas.Admin.ViewModels.Blog;
using Pustok_Backend.Areas.Admin.ViewModels.Tag;
using Pustok_Backend.Helpers;

namespace Pustok_Backend.ViewModels
{
    public class BlogPageVM
    {
        public Paginate<BlogVM> PaginatedDatas { get; set; }
        public List<TagVM> Tags { get; set; }

        public List<BlogVM> LatestBlogs { get; set; }
    }
}
